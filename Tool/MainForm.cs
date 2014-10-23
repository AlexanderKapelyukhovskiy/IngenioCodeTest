using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ingenio.CodeTest.Core;

namespace Ingenio.CodeTest.Tool
{
    public partial class MainForm : Form
    {
        private readonly DataLoander _dataLoander = new DataLoander();

        public MainForm()
        {
            InitializeComponent();
        }

        private DataService GetDataService()
        {
            var dataService = new DataService(_dataLoander.Load(txtData.Text));
            return dataService;
        }

        private void AppendResult(string result)
        {
            txtCallResults.AppendText(result);
            txtCallResults.AppendText(Environment.NewLine);
        }

        private void btnGetName_Click(object sender, EventArgs e)
        {
            var service = GetDataService();
            int categoryId;
            string categoryValue = txtCategoryId.Text;
            if (int.TryParse(categoryValue, out categoryId))
            {
                var found = service.GetItemWithKeywordByCategoryId(categoryId);
                if (found != null)
                    AppendResult(
                        string.Format("Found for CategoryId {0} - ParentCategoryID={1}, Name={2}, Keywords={3}",
                            categoryId, found.ParentCategoryId, found.Name, found.Keywords));
                else
                    AppendResult("Can't find correct item for categoryId " + categoryId);
            }
            else
            {
                MessageBox.Show("Can't parse " + categoryValue);
            }
        }

        private void btnGetCategoriesByLevel_Click(object sender, EventArgs e)
        {
            
            int level;
            string levelValue = txtLevel.Text;
            if (int.TryParse(levelValue, out level))
            {
                var service = GetDataService();
                var categories = service.GetCategoriesByLevel(level);
                if (categories != null && categories.Length > 0)
                {
                    var sb = new StringBuilder(categories[0]);
                    for (int i = 1; i < categories.Length; i++)
                    {
                        sb.AppendFormat(", {0}", categories[i]);
                    }
                    AppendResult(string.Format("For level {0} found - {1}", level, sb));
                }
                else
                    AppendResult("Can't find correct categories for level " + level);
            }
            else
            {
                MessageBox.Show("Can't parse " + levelValue);
            }

        }
    }
}
