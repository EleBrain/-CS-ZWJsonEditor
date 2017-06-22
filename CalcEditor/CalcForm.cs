using System.Windows.Forms;
using CalcData;

namespace CalcEditor {
    public partial class CalcForm : Form1<CalcDataRootBase> {

        public CalcForm() {
            InitializeComponent();
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e) {
            if (e.OldValue == null) return;
            if (e.ChangedItem.Parent.Value.ToString() == "" || e.OldValue.ToString() == "") return;
            ChangeNumberTarget(e);
            propertyGrid1.Refresh();
        }

        private static void ChangeNumberTarget(PropertyValueChangedEventArgs e) {
            if (!(e.ChangedItem.Parent.Value is CalcDataRootBase)) return;

            CalcDataRootBase parent = (CalcDataRootBase)e.ChangedItem.Parent.Value;
            if (e.OldValue is CalcRootType && (CalcRootType)e.OldValue == parent.RootType) {
                return;
            }
            switch (parent.RootType) {
                case CalcRootType.Number:
                    parent.IntList = new CalcDataNumber();
                    break;
                case CalcRootType.Addition:
                case CalcRootType.Subtraction:
                case CalcRootType.Multiplication:
                case CalcRootType.Division:
                case CalcRootType.Remainder:
                case CalcRootType.Random:
                    parent.IntList = new CalcDataCalc();
                    break;
                case CalcRootType.Unit:
                    parent.IntList = new CalcDataUnitList();
                    break;
                case CalcRootType.Land:
                    parent.IntList = new CalcDataLandList();
                    break;
                case CalcRootType.Player:
                    parent.IntList = new CalcDataPlayerList();
                    break;
                default:
                    break;
            }
        }
    }
}
