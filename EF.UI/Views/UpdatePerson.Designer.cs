
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
    
    
    public partial class UpdatePerson : Terminal.Gui.Window {
        
        private Terminal.Gui.Window detailsWindow;
        
        private Terminal.Gui.CheckBox publicFigureCheckBox;
        
        private Terminal.Gui.Label nameLabel;
        
        private Terminal.Gui.TextField nameTextField;
        
        private Terminal.Gui.Label surnameLabel;
        
        private Terminal.Gui.TextField surnameTextField;
        
        private Terminal.Gui.Label phonenumberLabel;
        
        private Terminal.Gui.TextField phonenumberTextField;
        
        private Terminal.Gui.Label capitalLabel;
        
        private Terminal.Gui.TextField capitalTextField;
        
        private Terminal.Gui.Label genderLabel;
        
        private Terminal.Gui.ComboBox genderComboBox;
        
        private Terminal.Gui.Button changePartnerButton;
        
        private Terminal.Gui.Button addParentButton;
        
        private Terminal.Gui.Button addChildButton;
        
        private Terminal.Gui.Button addSiblingButton;
        
        private Terminal.Gui.Button addEmploymentButton;
        
        private Terminal.Gui.Button removeParentButton;
        
        private Terminal.Gui.Button removeChildButton;
        
        private Terminal.Gui.Button removeSiblingButton;
        
        private Terminal.Gui.Button removeEmploymentButton;
        
        private Terminal.Gui.Window optionsWindow;
        
        private Terminal.Gui.Button updateButton;
        
        private Terminal.Gui.Button backButton;
        
        private void InitializeComponent() {
            this.backButton = new Terminal.Gui.Button();
            this.updateButton = new Terminal.Gui.Button();
            this.optionsWindow = new Terminal.Gui.Window();
            this.removeEmploymentButton = new Terminal.Gui.Button();
            this.removeSiblingButton = new Terminal.Gui.Button();
            this.removeChildButton = new Terminal.Gui.Button();
            this.removeParentButton = new Terminal.Gui.Button();
            this.addEmploymentButton = new Terminal.Gui.Button();
            this.addSiblingButton = new Terminal.Gui.Button();
            this.addChildButton = new Terminal.Gui.Button();
            this.addParentButton = new Terminal.Gui.Button();
            this.changePartnerButton = new Terminal.Gui.Button();
            this.genderComboBox = new Terminal.Gui.ComboBox();
            this.genderLabel = new Terminal.Gui.Label();
            this.capitalTextField = new Terminal.Gui.TextField();
            this.capitalLabel = new Terminal.Gui.Label();
            this.phonenumberTextField = new Terminal.Gui.TextField();
            this.phonenumberLabel = new Terminal.Gui.Label();
            this.surnameTextField = new Terminal.Gui.TextField();
            this.surnameLabel = new Terminal.Gui.Label();
            this.nameTextField = new Terminal.Gui.TextField();
            this.nameLabel = new Terminal.Gui.Label();
            this.publicFigureCheckBox = new Terminal.Gui.CheckBox();
            this.detailsWindow = new Terminal.Gui.Window();
            this.Width = Dim.Fill(0);
            this.Height = Dim.Fill(0);
            this.X = 0;
            this.Y = 0;
            this.Visible = true;
            this.Arrangement = (Terminal.Gui.ViewArrangement.Movable | Terminal.Gui.ViewArrangement.Overlapped);
            this.Modal = false;
            this.TextAlignment = Terminal.Gui.Alignment.Start;
            this.Title = "Update {Person}";
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
            this.publicFigureCheckBox.Width = Dim.Auto();
            this.publicFigureCheckBox.Height = 1;
            this.publicFigureCheckBox.X = 4;
            this.publicFigureCheckBox.Y = 1;
            this.publicFigureCheckBox.Visible = false;
            this.publicFigureCheckBox.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.publicFigureCheckBox.Data = "publicFigureCheckBox";
            this.publicFigureCheckBox.Text = "Public Figure";
            this.publicFigureCheckBox.TextAlignment = Terminal.Gui.Alignment.Start;
            this.publicFigureCheckBox.CheckedState = Terminal.Gui.CheckState.UnChecked;
            this.detailsWindow.Add(this.publicFigureCheckBox);
            this.nameLabel.Width = Dim.Auto();
            this.nameLabel.Height = 1;
            this.nameLabel.X = 29;
            this.nameLabel.Y = 7;
            this.nameLabel.Visible = true;
            this.nameLabel.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.nameLabel.Data = "nameLabel";
            this.nameLabel.Text = "Name:";
            this.nameLabel.TextAlignment = Terminal.Gui.Alignment.Start;
            this.detailsWindow.Add(this.nameLabel);
            this.nameTextField.Width = Dim.Fill(5);
            this.nameTextField.Height = 1;
            this.nameTextField.X = Pos.Right(nameLabel) + 10;
            this.nameTextField.Y = Pos.Top(nameLabel);
            this.nameTextField.Visible = true;
            this.nameTextField.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.nameTextField.Secret = false;
            this.nameTextField.Data = "nameTextField";
            this.nameTextField.Text = "Name";
            this.nameTextField.TextAlignment = Terminal.Gui.Alignment.Start;
            this.detailsWindow.Add(this.nameTextField);
            this.surnameLabel.Width = Dim.Auto();
            this.surnameLabel.Height = 1;
            this.surnameLabel.X = Pos.Left(nameLabel);
            this.surnameLabel.Y = Pos.Bottom(nameLabel) + 1;
            this.surnameLabel.Visible = true;
            this.surnameLabel.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.surnameLabel.Data = "surnameLabel";
            this.surnameLabel.Text = "Surname:";
            this.surnameLabel.TextAlignment = Terminal.Gui.Alignment.Start;
            this.detailsWindow.Add(this.surnameLabel);
            this.surnameTextField.Width = Dim.Fill(5);
            this.surnameTextField.Height = 1;
            this.surnameTextField.X = Pos.Left(nameTextField);
            this.surnameTextField.Y = Pos.Top(surnameLabel);
            this.surnameTextField.Visible = true;
            this.surnameTextField.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.surnameTextField.Secret = false;
            this.surnameTextField.Data = "surnameTextField";
            this.surnameTextField.Text = "Surname";
            this.surnameTextField.TextAlignment = Terminal.Gui.Alignment.Start;
            this.detailsWindow.Add(this.surnameTextField);
            this.phonenumberLabel.Width = Dim.Auto();
            this.phonenumberLabel.Height = 1;
            this.phonenumberLabel.X = Pos.Left(nameLabel);
            this.phonenumberLabel.Y = Pos.Bottom(surnameLabel) + 1;
            this.phonenumberLabel.Visible = true;
            this.phonenumberLabel.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.phonenumberLabel.Data = "phonenumberLabel";
            this.phonenumberLabel.Text = "PhoneNumber:";
            this.phonenumberLabel.TextAlignment = Terminal.Gui.Alignment.Start;
            this.detailsWindow.Add(this.phonenumberLabel);
            this.phonenumberTextField.Width = Dim.Fill(5);
            this.phonenumberTextField.Height = 1;
            this.phonenumberTextField.X = Pos.Left(nameTextField);
            this.phonenumberTextField.Y = Pos.Top(phonenumberLabel);
            this.phonenumberTextField.Visible = true;
            this.phonenumberTextField.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.phonenumberTextField.Secret = false;
            this.phonenumberTextField.Data = "phonenumberTextField";
            this.phonenumberTextField.Text = "Phonenumber";
            this.phonenumberTextField.TextAlignment = Terminal.Gui.Alignment.Start;
            this.detailsWindow.Add(this.phonenumberTextField);
            this.capitalLabel.Width = Dim.Auto();
            this.capitalLabel.Height = 1;
            this.capitalLabel.X = Pos.Left(nameLabel);
            this.capitalLabel.Y = Pos.Bottom(phonenumberLabel) + 1;
            this.capitalLabel.Visible = true;
            this.capitalLabel.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.capitalLabel.Data = "capitalLabel";
            this.capitalLabel.Text = "Capital:";
            this.capitalLabel.TextAlignment = Terminal.Gui.Alignment.Start;
            this.detailsWindow.Add(this.capitalLabel);
            this.capitalTextField.Width = Dim.Fill(5);
            this.capitalTextField.Height = 1;
            this.capitalTextField.X = Pos.Left(nameTextField);
            this.capitalTextField.Y = Pos.Top(capitalLabel);
            this.capitalTextField.Visible = true;
            this.capitalTextField.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.capitalTextField.Secret = false;
            this.capitalTextField.Data = "capitalTextField";
            this.capitalTextField.Text = "";
            this.capitalTextField.TextAlignment = Terminal.Gui.Alignment.Start;
            this.detailsWindow.Add(this.capitalTextField);
            this.genderLabel.Width = Dim.Auto();
            this.genderLabel.Height = 1;
            this.genderLabel.X = Pos.Left(nameLabel);
            this.genderLabel.Y = Pos.Bottom(capitalLabel) + 1;
            this.genderLabel.Visible = true;
            this.genderLabel.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.genderLabel.Data = "genderLabel";
            this.genderLabel.Text = "Gender:";
            this.genderLabel.TextAlignment = Terminal.Gui.Alignment.Start;
            this.detailsWindow.Add(this.genderLabel);
            this.genderComboBox.Width = Dim.Fill(5);
            this.genderComboBox.Height = 4;
            this.genderComboBox.X = Pos.Left(surnameTextField);
            this.genderComboBox.Y = Pos.Top(genderLabel);
            this.genderComboBox.Visible = true;
            this.genderComboBox.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.genderComboBox.Data = "genderComboBox";
            this.genderComboBox.Text = "";
            this.genderComboBox.TextAlignment = Terminal.Gui.Alignment.Start;
            this.detailsWindow.Add(this.genderComboBox);
            this.changePartnerButton.Width = Dim.Auto();
            this.changePartnerButton.Height = 1;
            this.changePartnerButton.X = 0;
            this.changePartnerButton.Y = 20;
            this.changePartnerButton.Visible = true;
            this.changePartnerButton.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.changePartnerButton.Data = "changePartnerButton";
            this.changePartnerButton.Text = "Change Partner";
            this.changePartnerButton.TextAlignment = Terminal.Gui.Alignment.Center;
            this.changePartnerButton.IsDefault = false;
            this.detailsWindow.Add(this.changePartnerButton);
            this.addParentButton.Width = Dim.Auto();
            this.addParentButton.Height = 1;
            this.addParentButton.X = 22;
            this.addParentButton.Y = 20;
            this.addParentButton.Visible = true;
            this.addParentButton.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.addParentButton.Data = "addParentButton";
            this.addParentButton.Text = "Add Parent";
            this.addParentButton.TextAlignment = Terminal.Gui.Alignment.Center;
            this.addParentButton.IsDefault = false;
            this.detailsWindow.Add(this.addParentButton);
            this.addChildButton.Width = Dim.Auto();
            this.addChildButton.Height = 1;
            this.addChildButton.X = 46;
            this.addChildButton.Y = 20;
            this.addChildButton.Visible = true;
            this.addChildButton.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.addChildButton.Data = "addChildButton";
            this.addChildButton.Text = "Add Child";
            this.addChildButton.TextAlignment = Terminal.Gui.Alignment.Center;
            this.addChildButton.IsDefault = false;
            this.detailsWindow.Add(this.addChildButton);
            this.addSiblingButton.Width = Dim.Auto();
            this.addSiblingButton.Height = 1;
            this.addSiblingButton.X = 70;
            this.addSiblingButton.Y = 20;
            this.addSiblingButton.Visible = true;
            this.addSiblingButton.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.addSiblingButton.Data = "addSiblingButton";
            this.addSiblingButton.Text = "Add Sibling";
            this.addSiblingButton.TextAlignment = Terminal.Gui.Alignment.Center;
            this.addSiblingButton.IsDefault = false;
            this.detailsWindow.Add(this.addSiblingButton);
            this.addEmploymentButton.Width = Dim.Auto();
            this.addEmploymentButton.Height = 1;
            this.addEmploymentButton.X = 94;
            this.addEmploymentButton.Y = 20;
            this.addEmploymentButton.Visible = true;
            this.addEmploymentButton.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.addEmploymentButton.Data = "addEmploymentButton";
            this.addEmploymentButton.Text = "Add Employment";
            this.addEmploymentButton.TextAlignment = Terminal.Gui.Alignment.Center;
            this.addEmploymentButton.IsDefault = false;
            this.detailsWindow.Add(this.addEmploymentButton);
            this.removeParentButton.Width = Dim.Auto();
            this.removeParentButton.Height = 1;
            this.removeParentButton.X = 21;
            this.removeParentButton.Y = 21;
            this.removeParentButton.Visible = true;
            this.removeParentButton.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.removeParentButton.Data = "removeParentButton";
            this.removeParentButton.Text = "Remove Parent";
            this.removeParentButton.TextAlignment = Terminal.Gui.Alignment.Center;
            this.removeParentButton.IsDefault = false;
            this.detailsWindow.Add(this.removeParentButton);
            this.removeChildButton.Width = Dim.Auto();
            this.removeChildButton.Height = 1;
            this.removeChildButton.X = 44;
            this.removeChildButton.Y = 21;
            this.removeChildButton.Visible = true;
            this.removeChildButton.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.removeChildButton.Data = "removeChildButton";
            this.removeChildButton.Text = "Remove Child";
            this.removeChildButton.TextAlignment = Terminal.Gui.Alignment.Center;
            this.removeChildButton.IsDefault = false;
            this.detailsWindow.Add(this.removeChildButton);
            this.removeSiblingButton.Width = Dim.Auto();
            this.removeSiblingButton.Height = 1;
            this.removeSiblingButton.X = 68;
            this.removeSiblingButton.Y = 21;
            this.removeSiblingButton.Visible = true;
            this.removeSiblingButton.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.removeSiblingButton.Data = "removeSiblingButton";
            this.removeSiblingButton.Text = "Remove Sibling";
            this.removeSiblingButton.TextAlignment = Terminal.Gui.Alignment.Center;
            this.removeSiblingButton.IsDefault = false;
            this.detailsWindow.Add(this.removeSiblingButton);
            this.removeEmploymentButton.Width = Dim.Auto();
            this.removeEmploymentButton.Height = 1;
            this.removeEmploymentButton.X = 92;
            this.removeEmploymentButton.Y = 21;
            this.removeEmploymentButton.Visible = true;
            this.removeEmploymentButton.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.removeEmploymentButton.Data = "removeEmploymentButton";
            this.removeEmploymentButton.Text = "Remove Employment";
            this.removeEmploymentButton.TextAlignment = Terminal.Gui.Alignment.Center;
            this.removeEmploymentButton.IsDefault = false;
            this.detailsWindow.Add(this.removeEmploymentButton);
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