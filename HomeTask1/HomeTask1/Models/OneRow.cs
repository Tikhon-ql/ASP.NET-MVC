using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace HomeTask1.Models
{
    public class OneRow
    {
        public int Id { get; set; }
        public DateTime DateOfMetting { get; set; }
        public string FirstCommand { get; set; }
        public string SecondCommand { get; set; }

        public OneRow(int id,DateTime dateOfMetting, string firstCommand, string secondCommand)
        {
            Id = id;
            DateOfMetting = dateOfMetting;
            FirstCommand = firstCommand;
            SecondCommand = secondCommand;
        }
        public OneRow()
        {

        }
    }
}