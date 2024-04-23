using System.Text.RegularExpressions;


namespace AC4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadFromDataBase();
            ComboBoxYearMinValue();
            ComboBoxComarcaDTOMinValue();
        }

        private List<ComarcaDTO> Comarques { get; set; }
        private int pageSize = 10;
        private int currentPage = 1;

        private void ReadFromDataBase()
        {
            ComarcaDAO comarcaDAO = new ComarcaDAO(NpgsqlUtils.OpenConnection());
            this.Comarques = comarcaDAO.GetAllComarques();
            PaginateData();
        }
        private void PaginateData()
        {
            int startIndex = (currentPage - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize - 1, this.Comarques.Count - 1);
            List<ComarcaDTO> currentPageData = this.Comarques.GetRange(startIndex, endIndex - startIndex + 1);
            dataGridView1.DataSource = currentPageData;
            rightArrow.Enabled = endIndex < this.Comarques.Count - 1;
            leftArrow.Enabled = currentPage > 1;
        }
        private void ComboBoxYearMinValue()
        {
            for (int i = this.Comarques.Select(x => x.Year).Distinct().Min(); i <= 2050; i++)
            {
                comboBoxYear.Items.Add(i);
            }
        }
        private void ComboBoxComarcaDTOMinValue()
        {
            var comarques = this.Comarques
                .GroupBy(c => c.Code)
                .Select(g => g.First())
                .ToDictionary(c => c.Code, c => c.Name);
            foreach (var comarca in comarques)
            {
                comboBoxComarca.Items.Add(comarca.Value);
            }
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row != -1)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[row];
                ComarcaDTO comarca = new ComarcaDTO
                {
                    Year = Convert.ToInt32(selectedRow.Cells["Year"].Value),
                    Code = Convert.ToInt32(selectedRow.Cells["Code"].Value),
                    Name = selectedRow.Cells["Name"].Value.ToString(),
                    Population = Convert.ToInt32(selectedRow.Cells["Population"].Value),
                    DomesticExpense = Convert.ToInt32(selectedRow.Cells["DomesticExpense"].Value),
                    EconomicalActivitiesExpense = Convert.ToInt32(selectedRow.Cells["EconomicalActivitiesExpense"].Value),
                    Total = Convert.ToInt32(selectedRow.Cells["Total"].Value),
                    IndividualExpense = Convert.ToDecimal(selectedRow.Cells["IndividualExpense"].Value)
                };
                IsBigCity(comarca);
                PrintDomesticAverageExpense(comarca);
                Consumes(comarca);
            }
        }
        private void IsBigCity(ComarcaDTO comarca)
        {
            labelGT.Text = comarca.Population > 200000 ? "Sí" : "No";
        }
        private void PrintDomesticAverageExpense(ComarcaDTO comarca)
        {
            var avgByComarcaDTO = this
                .Comarques.Where(c => c.Code == comarca.Code)
                .GroupBy(c => c.Code)
                .Select(g => new
                {
                    Code = g.Key,
                    g.First().Name,
                    AvgDomesticExpense = g.Average(c => c.DomesticExpense).ToString("0")
                });
            labelAvg.Text = avgByComarcaDTO.Max(c => c.AvgDomesticExpense);
        }
        private void Consumes(ComarcaDTO comarca)
        {
            int maxYear = this.Comarques.Max(c => c.Year);
            var filteredComarques = this.Comarques.Where(c => c.Year == maxYear);
            var mostExpensive = filteredComarques.Max(c => c.IndividualExpense);
            var lessExpensive = filteredComarques.Min(c => c.IndividualExpense);
            labelHighest.Text = comarca.IndividualExpense == mostExpensive ? "Sí" : "No";
            labelLowest.Text = comarca.IndividualExpense == lessExpensive ? "Sí" : "No";
            //En cas de que el consum sigui el més alt i el més baix alhora, es mostrarà "No" a les dues. Ex: és l'únic registre d'aquest any.
        }
        private void Persistence(ComboBox comboBoxYear, ComboBox comboBoxComarcaDTO, TextBox textBoxPopulation, TextBox textBoxDomNet, TextBox textBoxEconomical, TextBox textBoxTotal, TextBox textBoxDomCap)
        {
            var newComarcaDTO = new ComarcaDTO
            {
                Year = Convert.ToInt32(comboBoxYear.SelectedItem),
                Code = this.Comarques.Find(c => c.Name == comboBoxComarcaDTO.SelectedItem.ToString()).Code,
                Name = comboBoxComarcaDTO.SelectedItem.ToString(),
                Population = Convert.ToInt32(textBoxPopulation.Text),
                DomesticExpense = Convert.ToInt32(textBoxDomNet.Text),
                EconomicalActivitiesExpense = Convert.ToInt32(textBoxEconomical.Text),
                Total = Convert.ToInt32(textBoxTotal.Text),
                IndividualExpense = decimal.Parse(textBoxDomCap.Text)
            };
            ComarcaDAO comarcaDAO = new ComarcaDAO(NpgsqlUtils.OpenConnection());
            comarcaDAO.InsertComarca(newComarcaDTO);            
            dataGridView1.DataSource = null;
            ReadFromDataBase();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            Regex integerPattern = new Regex(@"^[0-9]{1,7}$");
            Regex decimalPattern = new Regex(@"^[0-9]+(?:[\,]\d+)?$");

            if (comboBoxYear.SelectedItem == null)
                MessageBox.Show("Selecciona un any", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (comboBoxComarca.SelectedItem == null)
                MessageBox.Show("Selecciona una comarca", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!integerPattern.IsMatch(textBoxPopulation.Text))
                MessageBox.Show("La població ha de ser un número positiu i enter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!integerPattern.IsMatch(textBoxDomNet.Text))
                MessageBox.Show("El consum domèstic ha de ser un número positiu i enter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!integerPattern.IsMatch(textBoxEconomical.Text))
                MessageBox.Show("El consum d'activitats econòmiques ha de ser un número positiu i enter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!integerPattern.IsMatch(textBoxTotal.Text))
                MessageBox.Show("El total ha de ser un número positiu i enter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!decimalPattern.IsMatch(textBoxDomCap.Text))
                MessageBox.Show("El consum per càpita ha de ser un número positiu (decimals amb coma)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Persistence(comboBoxYear, comboBoxComarca, textBoxPopulation, textBoxDomNet, textBoxEconomical, textBoxTotal, textBoxDomCap);
                this.Comarques.Clear();
                CleanInputs();
            }
        }
        private void CleanInputs()
        {
            comboBoxYear.SelectedItem = null;
            comboBoxComarca.SelectedItem = null;
            textBoxPopulation.Text = "";
            textBoxDomNet.Text = "";
            textBoxEconomical.Text = "";
            textBoxTotal.Text = "";
            textBoxDomCap.Text = "";
        }
        private void Clean_Click(object sender, EventArgs e)
        {
            CleanInputs();
        }
        private void leftArrow_Click(object sender, EventArgs e)
        {
            currentPage--;
            ReadFromDataBase();
        }
        private void rightArrow_Click(object sender, EventArgs e)
        {
            currentPage++;
            ReadFromDataBase();
        }
    }
}
