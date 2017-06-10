using System;
using System.Windows.Forms;

namespace CalcEditor {
    public partial class CalcForm : Form1<Data> {

        public CalcForm() {
            InitializeComponent();
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e) {
            ChangeNumberTarget(e);
            ChangeListTarget(e);
        }

        private static void ChangeNumberTarget(PropertyValueChangedEventArgs e) {
            if (!(e.ChangedItem.Parent.Value is CalcDataNumberBase)) return;

            CalcDataNumberBase parent = (CalcDataNumberBase)e.ChangedItem.Parent.Value;
            switch (parent.RootType) {
                case CalcRootType.Number:
                    break;
                case CalcRootType.Addition:
                case CalcRootType.Subtraction:
                case CalcRootType.Multiplication:
                case CalcRootType.Division:
                case CalcRootType.Remainder:
                case CalcRootType.Random:
                    if (parent.Child1 == null) {
                        parent.Child1 = new CalcDataNumber();
                    }
                    if (parent.Child2 == null) {
                        parent.Child2 = new CalcDataNumber();
                    }
                    break;
                case CalcRootType.Together:
                    if (parent.TogeterData == null) {
                        parent.TogeterData = new CalcDataTogether();
                    }
                    break;
                default:
                    break;
            }
        }
        private static void ChangeListTarget(PropertyValueChangedEventArgs e) {
            Console.WriteLine(e.ChangedItem.Parent.Value);
            if (!(e.ChangedItem.Parent.Value is CalcDataIntList)) return;
            
            CalcDataIntList parent = (CalcDataIntList)e.ChangedItem.Parent.Value;
            switch (parent.ListTargetType) {
                case CalcListTargetType.Unit:
                    parent.ControlListData = new CalcDataControlUnitList();
                    break;
                case CalcListTargetType.Land:
                    parent.ControlListData = new CalcDataControlLandList();
                    break;
                case CalcListTargetType.Player:
                    parent.ControlListData = new CalcDataPlayerList();
                    break;
                default:
                    break;
            }
        }


    }
}
