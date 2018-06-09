using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfApplication01
{
    public partial class _02_ControlsStyle : Page
    {
        private List<Style> _lstStylesCombo1 = new List<Style>();
        private List<Style> _lstStylesCombo2 = new List<Style>();

        public _02_ControlsStyle()
        {
            InitializeComponent();

            // save styles of each item for reset button
            foreach (var item in cmbOne.Items)
            {
                _lstStylesCombo1.Add(((ComboBoxItem)item).Style);
            }
            foreach (var item in cmbTwo.Items)
            {
                _lstStylesCombo2.Add(((ComboBoxItem)item).Style);
            }
        }

        private void btnCopyStylesToAllItems_Click(object sender, RoutedEventArgs e)
        {
            Style objStyle1 = ((Style)FindResource("myComboStyle1"));
            Style objStyle2 = ((Style)FindResource("myComboStyle2"));
            //Style objStyle3 = ((Style)FindResource("myComboStyle3"));
            //Style objStyle4 = ((Style)FindResource("myComboStyle4"));

            foreach (var objItem in cmbOne.Items)
            {
                (objItem as ComboBoxItem).Style = objStyle1;
            }

            foreach (var objItem in cmbTwo.Items)
            {
                (objItem as ComboBoxItem).Style = objStyle2;
            }
        }

        private void btnResetStyles_Click(object sender, RoutedEventArgs e)
        {
            for (int itemCmb1Index = 0; itemCmb1Index < _lstStylesCombo1.Count; itemCmb1Index++)
            {
                ((ComboBoxItem)cmbOne.Items[itemCmb1Index]).Style = _lstStylesCombo1[itemCmb1Index];
            }

            for (int itemCmb2Index = 0; itemCmb2Index < _lstStylesCombo2.Count; itemCmb2Index++)
            {
                ((ComboBoxItem)cmbTwo.Items[itemCmb2Index]).Style = _lstStylesCombo2[itemCmb2Index];
            }
        }
    }
}