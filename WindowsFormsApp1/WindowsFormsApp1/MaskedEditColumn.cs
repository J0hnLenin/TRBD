using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
 
namespace MyDataGridView
{
    class MaskedEditColumn : DataGridViewColumn
    {
        public MaskedEditColumn() : base(new MaskedEditCell())
        { }
        public string MyHeaderText = "";
        public MaskedEditColumn(string Text): base(new MaskedEditCell())
        { MyHeaderText = Text; }
 
        public override DataGridViewCell CellTemplate
        {
            get
            {
                base.HeaderText = MyHeaderText;
                return base.CellTemplate;
            }
            set
            {
                if ((value != null) && !value.GetType().IsAssignableFrom(typeof(MaskedEditCell)))
                    throw new InvalidCastException("Must be a MaskedEditCell");
                base.CellTemplate = value;
            }
        }
        private string mask;
 
        public string Mask
        {
            get { return mask; }
            set { mask = value; }
        }
        private Type validatingType;
 
        public Type ValidatingType
        {
            get { return validatingType; }
            set { validatingType = value; }
        }
 
        private char promtChar = '_';
 
        public char PromtChar
        {
            get { return promtChar; }
            set { promtChar = value; }
        }
        private MaskedEditCell MaskedEditCellTemplate
        {
            get { return this.CellTemplate as MaskedEditCell; }
        }
    }
}