
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
    
    
    public partial class FakeDataView : Terminal.Gui.Window {
        
        private Terminal.Gui.Window dataWindow;
        
        private Terminal.Gui.Label label4;
        
        private Terminal.Gui.Label label2;
        
        private Terminal.Gui.Label label;
        
        private Terminal.Gui.Label label3;
        
        private Terminal.Gui.Label peopleLabel;
        
        private Terminal.Gui.TextField peopleTextField;
        
        private Terminal.Gui.TextField partnerPercTextField;
        
        private Terminal.Gui.TextField parentPercTextField;
        
        private Terminal.Gui.TextField siblingPercTextField;
        
        private Terminal.Gui.TextField employmentPercTextField;
        
        private Terminal.Gui.Label employmentsLabel;
        
        private Terminal.Gui.TextField employmentsTextField;
        
        private Terminal.Gui.Label publicFiguresLabel;
        
        private Terminal.Gui.TextField publicFiguresTextField;
        
        private Terminal.Gui.Window optionsWindow;
        
        private Terminal.Gui.Button generateButton;
        
        private Terminal.Gui.Button backButton;
        
        private void InitializeComponent() {
            this.backButton = new Terminal.Gui.Button();
            this.generateButton = new Terminal.Gui.Button();
            this.optionsWindow = new Terminal.Gui.Window();
            this.publicFiguresTextField = new Terminal.Gui.TextField();
            this.publicFiguresLabel = new Terminal.Gui.Label();
            this.employmentsTextField = new Terminal.Gui.TextField();
            this.employmentsLabel = new Terminal.Gui.Label();
            this.employmentPercTextField = new Terminal.Gui.TextField();
            this.siblingPercTextField = new Terminal.Gui.TextField();
            this.parentPercTextField = new Terminal.Gui.TextField();
            this.partnerPercTextField = new Terminal.Gui.TextField();
            this.peopleTextField = new Terminal.Gui.TextField();
            this.peopleLabel = new Terminal.Gui.Label();
            this.label3 = new Terminal.Gui.Label();
            this.label = new Terminal.Gui.Label();
            this.label2 = new Terminal.Gui.Label();
            this.label4 = new Terminal.Gui.Label();
            this.dataWindow = new Terminal.Gui.Window();
            this.Width = Dim.Fill(0);
            this.Height = Dim.Fill(0);
            this.X = 0;
            this.Y = 0;
            this.Visible = true;
            this.Arrangement = (Terminal.Gui.ViewArrangement.Movable | Terminal.Gui.ViewArrangement.Overlapped);
            this.Modal = false;
            this.TextAlignment = Terminal.Gui.Alignment.Start;
            this.Title = "Add Fake Data";
            this.dataWindow.Width = Dim.Fill(0);
            this.dataWindow.Height = Dim.Percent(90);
            this.dataWindow.X = Pos.Center();
            this.dataWindow.Y = 0;
            this.dataWindow.Visible = true;
            this.dataWindow.Arrangement = (Terminal.Gui.ViewArrangement.Movable | Terminal.Gui.ViewArrangement.Overlapped);
            this.dataWindow.Modal = false;
            this.dataWindow.Data = "dataWindow";
            this.dataWindow.TextAlignment = Terminal.Gui.Alignment.Start;
            this.dataWindow.Title = "";
            this.Add(this.dataWindow);
            this.label4.Width = Dim.Auto();
            this.label4.Height = 1;
            this.label4.X = 52;
            this.label4.Y = 7;
            this.label4.Visible = true;
            this.label4.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.label4.Data = "label4";
            this.label4.Text = "Partner";
            this.label4.TextAlignment = Terminal.Gui.Alignment.Start;
            this.dataWindow.Add(this.label4);
            this.label2.Width = Dim.Auto();
            this.label2.Height = 1;
            this.label2.X = 63;
            this.label2.Y = 7;
            this.label2.Visible = true;
            this.label2.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.label2.Data = "label2";
            this.label2.Text = "Parent";
            this.label2.TextAlignment = Terminal.Gui.Alignment.Start;
            this.dataWindow.Add(this.label2);
            this.label.Width = Dim.Auto();
            this.label.Height = 1;
            this.label.X = 73;
            this.label.Y = 7;
            this.label.Visible = true;
            this.label.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.label.Data = "label";
            this.label.Text = "Sibling";
            this.label.TextAlignment = Terminal.Gui.Alignment.Start;
            this.dataWindow.Add(this.label);
            this.label3.Width = Dim.Auto();
            this.label3.Height = 1;
            this.label3.X = 83;
            this.label3.Y = 7;
            this.label3.Visible = true;
            this.label3.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.label3.Data = "label3";
            this.label3.Text = "Employment";
            this.label3.TextAlignment = Terminal.Gui.Alignment.Start;
            this.dataWindow.Add(this.label3);
            this.peopleLabel.Width = Dim.Auto();
            this.peopleLabel.Height = 1;
            this.peopleLabel.X = 27;
            this.peopleLabel.Y = 9;
            this.peopleLabel.Visible = true;
            this.peopleLabel.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.peopleLabel.Data = "peopleLabel";
            this.peopleLabel.Text = "People:";
            this.peopleLabel.TextAlignment = Terminal.Gui.Alignment.Start;
            this.dataWindow.Add(this.peopleLabel);
            this.peopleTextField.Width = 5;
            this.peopleTextField.Height = 1;
            this.peopleTextField.X = Pos.Right(peopleLabel) + 10;
            this.peopleTextField.Y = Pos.Top(peopleLabel);
            this.peopleTextField.Visible = true;
            this.peopleTextField.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.peopleTextField.Secret = false;
            this.peopleTextField.Data = "peopleTextField";
            this.peopleTextField.Text = "10";
            this.peopleTextField.TextAlignment = Terminal.Gui.Alignment.Start;
            this.dataWindow.Add(this.peopleTextField);
            this.partnerPercTextField.Width = 5;
            this.partnerPercTextField.Height = 1;
            this.partnerPercTextField.X = Pos.Right(peopleLabel) + 20;
            this.partnerPercTextField.Y = Pos.Top(peopleLabel);
            this.partnerPercTextField.Visible = true;
            this.partnerPercTextField.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.partnerPercTextField.Secret = false;
            this.partnerPercTextField.Data = "partnerPercTextField";
            this.partnerPercTextField.Text = "50";
            this.partnerPercTextField.TextAlignment = Terminal.Gui.Alignment.Start;
            this.dataWindow.Add(this.partnerPercTextField);
            this.parentPercTextField.Width = 5;
            this.parentPercTextField.Height = 1;
            this.parentPercTextField.X = Pos.Right(peopleLabel) + 30;
            this.parentPercTextField.Y = Pos.Top(peopleLabel);
            this.parentPercTextField.Visible = true;
            this.parentPercTextField.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.parentPercTextField.Secret = false;
            this.parentPercTextField.Data = "parentPercTextField";
            this.parentPercTextField.Text = "80";
            this.parentPercTextField.TextAlignment = Terminal.Gui.Alignment.Start;
            this.dataWindow.Add(this.parentPercTextField);
            this.siblingPercTextField.Width = 5;
            this.siblingPercTextField.Height = 1;
            this.siblingPercTextField.X = Pos.Right(peopleLabel) + 40;
            this.siblingPercTextField.Y = Pos.Top(peopleLabel);
            this.siblingPercTextField.Visible = true;
            this.siblingPercTextField.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.siblingPercTextField.Secret = false;
            this.siblingPercTextField.Data = "siblingPercTextField";
            this.siblingPercTextField.Text = "60";
            this.siblingPercTextField.TextAlignment = Terminal.Gui.Alignment.Start;
            this.dataWindow.Add(this.siblingPercTextField);
            this.employmentPercTextField.Width = 5;
            this.employmentPercTextField.Height = 1;
            this.employmentPercTextField.X = Pos.Right(peopleLabel) + 50;
            this.employmentPercTextField.Y = Pos.Top(peopleLabel);
            this.employmentPercTextField.Visible = true;
            this.employmentPercTextField.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.employmentPercTextField.Secret = false;
            this.employmentPercTextField.Data = "employmentPercTextField";
            this.employmentPercTextField.Text = "70";
            this.employmentPercTextField.TextAlignment = Terminal.Gui.Alignment.Start;
            this.dataWindow.Add(this.employmentPercTextField);
            this.employmentsLabel.Width = Dim.Auto();
            this.employmentsLabel.Height = 1;
            this.employmentsLabel.X = 25;
            this.employmentsLabel.Y = 11;
            this.employmentsLabel.Visible = true;
            this.employmentsLabel.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.employmentsLabel.Data = "employmentsLabel";
            this.employmentsLabel.Text = "Employments:";
            this.employmentsLabel.TextAlignment = Terminal.Gui.Alignment.Start;
            this.dataWindow.Add(this.employmentsLabel);
            this.employmentsTextField.Width = 5;
            this.employmentsTextField.Height = 1;
            this.employmentsTextField.X = Pos.Right(peopleLabel) + 10;
            this.employmentsTextField.Y = Pos.Top(employmentsLabel);
            this.employmentsTextField.Visible = true;
            this.employmentsTextField.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.employmentsTextField.Secret = false;
            this.employmentsTextField.Data = "employmentsTextField";
            this.employmentsTextField.Text = "10";
            this.employmentsTextField.TextAlignment = Terminal.Gui.Alignment.Start;
            this.dataWindow.Add(this.employmentsTextField);
            this.publicFiguresLabel.Width = Dim.Auto();
            this.publicFiguresLabel.Height = 1;
            this.publicFiguresLabel.X = 24;
            this.publicFiguresLabel.Y = 13;
            this.publicFiguresLabel.Visible = true;
            this.publicFiguresLabel.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.publicFiguresLabel.Data = "publicFiguresLabel";
            this.publicFiguresLabel.Text = "Public Figures:";
            this.publicFiguresLabel.TextAlignment = Terminal.Gui.Alignment.Start;
            this.dataWindow.Add(this.publicFiguresLabel);
            this.publicFiguresTextField.Width = 5;
            this.publicFiguresTextField.Height = 1;
            this.publicFiguresTextField.X = Pos.Right(peopleLabel) + 10;
            this.publicFiguresTextField.Y = Pos.Top(publicFiguresLabel);
            this.publicFiguresTextField.Visible = true;
            this.publicFiguresTextField.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.publicFiguresTextField.Secret = false;
            this.publicFiguresTextField.Data = "publicFiguresTextField";
            this.publicFiguresTextField.Text = "10";
            this.publicFiguresTextField.TextAlignment = Terminal.Gui.Alignment.Start;
            this.dataWindow.Add(this.publicFiguresTextField);
            this.optionsWindow.Width = Dim.Fill(0);
            this.optionsWindow.Height = Dim.Fill(0);
            this.optionsWindow.X = Pos.Center();
            this.optionsWindow.Y = Pos.Bottom(dataWindow);
            this.optionsWindow.Visible = true;
            this.optionsWindow.Arrangement = (Terminal.Gui.ViewArrangement.Movable | Terminal.Gui.ViewArrangement.Overlapped);
            this.optionsWindow.Modal = false;
            this.optionsWindow.Data = "optionsWindow";
            this.optionsWindow.TextAlignment = Terminal.Gui.Alignment.Start;
            this.optionsWindow.Title = "";
            this.Add(this.optionsWindow);
            this.generateButton.Width = Dim.Auto();
            this.generateButton.Height = 1;
            this.generateButton.X = Pos.Center() - 10;
            this.generateButton.Y = Pos.Center();
            this.generateButton.Visible = true;
            this.generateButton.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.generateButton.Data = "generateButton";
            this.generateButton.Text = "Generate";
            this.generateButton.TextAlignment = Terminal.Gui.Alignment.Center;
            this.generateButton.IsDefault = false;
            this.optionsWindow.Add(this.generateButton);
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