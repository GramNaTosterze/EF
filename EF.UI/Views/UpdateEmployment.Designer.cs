
//------------------------------------------------------------------------------

//  <auto-generated>
//      This code was generated by:
//        TerminalGuiDesigner v2.0.0.0
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// -----------------------------------------------------------------------------
namespace EF.UI.Views {
    using System;
    using Terminal.Gui;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Drawing;
    
    
    public partial class UpdateEmployment : Terminal.Gui.Window {
        
        private Terminal.Gui.Window detailsWindow;
        
        private Terminal.Gui.Label companyLabel;
        
        private Terminal.Gui.TextField companyTextField;
        
        private Terminal.Gui.Label contractLabel;
        
        private Terminal.Gui.TextField contractTextField;
        
        private Terminal.Gui.Label payLabel;
        
        private Terminal.Gui.TextField payTextField;
        
        private Terminal.Gui.Button addEmployeeButton;
        
        private Terminal.Gui.Button removeEmployeeButton;
        
        private Terminal.Gui.Window optionsWindow;
        
        private Terminal.Gui.Button updateButton;
        
        private Terminal.Gui.Button backButton;
        
        private void InitializeComponent() {
            this.backButton = new Terminal.Gui.Button();
            this.updateButton = new Terminal.Gui.Button();
            this.optionsWindow = new Terminal.Gui.Window();
            this.removeEmployeeButton = new Terminal.Gui.Button();
            this.addEmployeeButton = new Terminal.Gui.Button();
            this.payTextField = new Terminal.Gui.TextField();
            this.payLabel = new Terminal.Gui.Label();
            this.contractTextField = new Terminal.Gui.TextField();
            this.contractLabel = new Terminal.Gui.Label();
            this.companyTextField = new Terminal.Gui.TextField();
            this.companyLabel = new Terminal.Gui.Label();
            this.detailsWindow = new Terminal.Gui.Window();
            this.Width = Dim.Fill(0);
            this.Height = Dim.Fill(0);
            this.X = 0;
            this.Y = 0;
            this.Visible = true;
            this.Arrangement = (Terminal.Gui.ViewArrangement.Movable | Terminal.Gui.ViewArrangement.Overlapped);
            this.Modal = false;
            this.TextAlignment = Terminal.Gui.Alignment.Start;
            this.Title = "Update {Employment}";
            this.detailsWindow.Width = Dim.Fill(0);
            this.detailsWindow.Height = Dim.Percent(90);
            this.detailsWindow.X = Pos.Center();
            this.detailsWindow.Y = 0;
            this.detailsWindow.Visible = true;
            this.detailsWindow.Arrangement = (Terminal.Gui.ViewArrangement.Movable | Terminal.Gui.ViewArrangement.Overlapped);
            this.detailsWindow.Modal = false;
            this.detailsWindow.Data = "detailsWindow";
            this.detailsWindow.TextAlignment = Terminal.Gui.Alignment.Start;
            this.detailsWindow.Title = "Fields";
            this.Add(this.detailsWindow);
            this.companyLabel.Width = Dim.Auto();
            this.companyLabel.Height = 1;
            this.companyLabel.X = 29;
            this.companyLabel.Y = 7;
            this.companyLabel.Visible = true;
            this.companyLabel.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.companyLabel.Data = "companyLabel";
            this.companyLabel.Text = "Company:";
            this.companyLabel.TextAlignment = Terminal.Gui.Alignment.Start;
            this.detailsWindow.Add(this.companyLabel);
            this.companyTextField.Width = Dim.Fill(5);
            this.companyTextField.Height = 1;
            this.companyTextField.X = Pos.Right(companyLabel) + 10;
            this.companyTextField.Y = Pos.Top(companyLabel);
            this.companyTextField.Visible = true;
            this.companyTextField.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.companyTextField.Secret = false;
            this.companyTextField.Data = "companyTextField";
            this.companyTextField.Text = "Name";
            this.companyTextField.TextAlignment = Terminal.Gui.Alignment.Start;
            this.detailsWindow.Add(this.companyTextField);
            this.contractLabel.Width = Dim.Auto();
            this.contractLabel.Height = 1;
            this.contractLabel.X = Pos.Left(companyLabel);
            this.contractLabel.Y = Pos.Bottom(companyLabel) + 1;
            this.contractLabel.Visible = true;
            this.contractLabel.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.contractLabel.Data = "contractLabel";
            this.contractLabel.Text = "Contract:";
            this.contractLabel.TextAlignment = Terminal.Gui.Alignment.Start;
            this.detailsWindow.Add(this.contractLabel);
            this.contractTextField.Width = Dim.Fill(5);
            this.contractTextField.Height = 1;
            this.contractTextField.X = Pos.Left(companyTextField);
            this.contractTextField.Y = Pos.Top(contractLabel);
            this.contractTextField.Visible = true;
            this.contractTextField.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.contractTextField.Secret = false;
            this.contractTextField.Data = "contractTextField";
            this.contractTextField.Text = "Surname";
            this.contractTextField.TextAlignment = Terminal.Gui.Alignment.Start;
            this.detailsWindow.Add(this.contractTextField);
            this.payLabel.Width = Dim.Auto();
            this.payLabel.Height = 1;
            this.payLabel.X = Pos.Left(companyLabel);
            this.payLabel.Y = Pos.Bottom(contractLabel) + 1;
            this.payLabel.Visible = true;
            this.payLabel.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.payLabel.Data = "payLabel";
            this.payLabel.Text = "Pay:";
            this.payLabel.TextAlignment = Terminal.Gui.Alignment.Start;
            this.detailsWindow.Add(this.payLabel);
            this.payTextField.Width = Dim.Fill(5);
            this.payTextField.Height = 1;
            this.payTextField.X = Pos.Left(companyTextField);
            this.payTextField.Y = Pos.Top(payLabel);
            this.payTextField.Visible = true;
            this.payTextField.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.payTextField.Secret = false;
            this.payTextField.Data = "payTextField";
            this.payTextField.Text = "Phonenumber";
            this.payTextField.TextAlignment = Terminal.Gui.Alignment.Start;
            this.detailsWindow.Add(this.payTextField);
            this.addEmployeeButton.Width = Dim.Auto();
            this.addEmployeeButton.Height = 1;
            this.addEmployeeButton.X = 52;
            this.addEmployeeButton.Y = 20;
            this.addEmployeeButton.Visible = true;
            this.addEmployeeButton.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.addEmployeeButton.Data = "addEmployeeButton";
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.TextAlignment = Terminal.Gui.Alignment.Center;
            this.addEmployeeButton.IsDefault = false;
            this.detailsWindow.Add(this.addEmployeeButton);
            this.removeEmployeeButton.Width = Dim.Auto();
            this.removeEmployeeButton.Height = 1;
            this.removeEmployeeButton.X = 51;
            this.removeEmployeeButton.Y = 21;
            this.removeEmployeeButton.Visible = true;
            this.removeEmployeeButton.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.removeEmployeeButton.Data = "removeEmployeeButton";
            this.removeEmployeeButton.Text = "Remove Employee";
            this.removeEmployeeButton.TextAlignment = Terminal.Gui.Alignment.Center;
            this.removeEmployeeButton.IsDefault = false;
            this.detailsWindow.Add(this.removeEmployeeButton);
            this.optionsWindow.Width = Dim.Fill(0);
            this.optionsWindow.Height = Dim.Fill(0);
            this.optionsWindow.X = Pos.Center();
            this.optionsWindow.Y = Pos.Bottom(detailsWindow);
            this.optionsWindow.Visible = true;
            this.optionsWindow.Arrangement = (Terminal.Gui.ViewArrangement.Movable | Terminal.Gui.ViewArrangement.Overlapped);
            this.optionsWindow.Modal = false;
            this.optionsWindow.Data = "optionsWindow";
            this.optionsWindow.TextAlignment = Terminal.Gui.Alignment.Start;
            this.optionsWindow.Title = "Options";
            this.Add(this.optionsWindow);
            this.updateButton.Width = Dim.Auto();
            this.updateButton.Height = 1;
            this.updateButton.X = Pos.Center() - 10;
            this.updateButton.Y = Pos.Center();
            this.updateButton.Visible = true;
            this.updateButton.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.updateButton.Data = "updateButton";
            this.updateButton.Text = "Update";
            this.updateButton.TextAlignment = Terminal.Gui.Alignment.Center;
            this.updateButton.IsDefault = false;
            this.optionsWindow.Add(this.updateButton);
            this.backButton.Width = Dim.Auto();
            this.backButton.Height = 1;
            this.backButton.X = Pos.Center() + 10;
            this.backButton.Y = Pos.Center();
            this.backButton.Visible = true;
            this.backButton.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.backButton.Data = "backButton";
            this.backButton.Text = "Back";
            this.backButton.TextAlignment = Terminal.Gui.Alignment.Center;
            this.backButton.IsDefault = false;
            this.optionsWindow.Add(this.backButton);
        }
    }
}
