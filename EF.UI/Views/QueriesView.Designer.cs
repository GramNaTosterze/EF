
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
    
    
    public partial class QueriesView : Terminal.Gui.Window {
        
        private Terminal.Gui.Window queriesWindow;
        
        private Terminal.Gui.Button personQuerieButton;
        
        private Terminal.Gui.ComboBox genderComboBox;
        
        private Terminal.Gui.ComboBox comboBox;
        
        private Terminal.Gui.ComboBox comboBox2;
        
        private Terminal.Gui.Button employmentQuerieButton;
        
        private Terminal.Gui.Button publicFigureQuerieButton;
        
        private Terminal.Gui.Window outputWindow;
        
        private Terminal.Gui.ListView outputListView;
        
        private Terminal.Gui.Window optionWindow;
        
        private Terminal.Gui.Button backButton;
        
        private void InitializeComponent() {
            this.backButton = new Terminal.Gui.Button();
            this.optionWindow = new Terminal.Gui.Window();
            this.outputListView = new Terminal.Gui.ListView();
            this.outputWindow = new Terminal.Gui.Window();
            this.publicFigureQuerieButton = new Terminal.Gui.Button();
            this.employmentQuerieButton = new Terminal.Gui.Button();
            this.comboBox2 = new Terminal.Gui.ComboBox();
            this.comboBox = new Terminal.Gui.ComboBox();
            this.genderComboBox = new Terminal.Gui.ComboBox();
            this.personQuerieButton = new Terminal.Gui.Button();
            this.queriesWindow = new Terminal.Gui.Window();
            this.Width = Dim.Fill(0);
            this.Height = Dim.Fill(0);
            this.X = 0;
            this.Y = 0;
            this.Visible = true;
            this.Arrangement = (Terminal.Gui.ViewArrangement.Movable | Terminal.Gui.ViewArrangement.Overlapped);
            this.Modal = false;
            this.TextAlignment = Terminal.Gui.Alignment.Start;
            this.Title = "Example Queries";
            this.queriesWindow.Width = Dim.Percent(50);
            this.queriesWindow.Height = 21;
            this.queriesWindow.X = 0;
            this.queriesWindow.Y = 0;
            this.queriesWindow.Visible = true;
            this.queriesWindow.Arrangement = (Terminal.Gui.ViewArrangement.Movable | Terminal.Gui.ViewArrangement.Overlapped);
            this.queriesWindow.Modal = false;
            this.queriesWindow.Data = "queriesWindow";
            this.queriesWindow.TextAlignment = Terminal.Gui.Alignment.Start;
            this.queriesWindow.Title = "Queries";
            this.Add(this.queriesWindow);
            this.personQuerieButton.Width = Dim.Auto();
            this.personQuerieButton.Height = 1;
            this.personQuerieButton.X = Pos.Center();
            this.personQuerieButton.Y = 3;
            this.personQuerieButton.Visible = true;
            this.personQuerieButton.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.personQuerieButton.Data = "personQuerieButton";
            this.personQuerieButton.Text = "Person Querie";
            this.personQuerieButton.TextAlignment = Terminal.Gui.Alignment.Center;
            this.personQuerieButton.IsDefault = false;
            this.queriesWindow.Add(this.personQuerieButton);
            this.genderComboBox.Width = Dim.Auto();
            this.genderComboBox.Height = 2;
            this.genderComboBox.X = Pos.Right(personQuerieButton) + 1;
            this.genderComboBox.Y = Pos.Top(personQuerieButton);
            this.genderComboBox.Visible = true;
            this.genderComboBox.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.genderComboBox.Data = "genderComboBox";
            this.genderComboBox.Text = "";
            this.genderComboBox.TextAlignment = Terminal.Gui.Alignment.Start;
            this.queriesWindow.Add(this.genderComboBox);
            this.comboBox.Width = Dim.Auto();
            this.comboBox.Height = 2;
            this.comboBox.X = Pos.Right(personQuerieButton) + 2;
            this.comboBox.Y = Pos.Top(personQuerieButton);
            this.comboBox.Visible = true;
            this.comboBox.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.comboBox.Data = "comboBox";
            this.comboBox.Text = "";
            this.comboBox.TextAlignment = Terminal.Gui.Alignment.Start;
            this.queriesWindow.Add(this.comboBox);
            this.comboBox2.Width = Dim.Auto();
            this.comboBox2.Height = 2;
            this.comboBox2.X = 4;
            this.comboBox2.Y = 4;
            this.comboBox2.Visible = true;
            this.comboBox2.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.comboBox2.Data = "comboBox2";
            this.comboBox2.Text = "";
            this.comboBox2.TextAlignment = Terminal.Gui.Alignment.Start;
            this.queriesWindow.Add(this.comboBox2);
            this.employmentQuerieButton.Width = Dim.Auto();
            this.employmentQuerieButton.Height = 1;
            this.employmentQuerieButton.X = Pos.Center();
            this.employmentQuerieButton.Y = 6;
            this.employmentQuerieButton.Visible = true;
            this.employmentQuerieButton.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.employmentQuerieButton.Data = "employmentQuerieButton";
            this.employmentQuerieButton.Text = "Employment Querie";
            this.employmentQuerieButton.TextAlignment = Terminal.Gui.Alignment.Center;
            this.employmentQuerieButton.IsDefault = false;
            this.queriesWindow.Add(this.employmentQuerieButton);
            this.publicFigureQuerieButton.Width = Dim.Auto();
            this.publicFigureQuerieButton.Height = 1;
            this.publicFigureQuerieButton.X = Pos.Center();
            this.publicFigureQuerieButton.Y = 9;
            this.publicFigureQuerieButton.Visible = true;
            this.publicFigureQuerieButton.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.publicFigureQuerieButton.Data = "publicFigureQuerieButton";
            this.publicFigureQuerieButton.Text = "Public Figure Querie";
            this.publicFigureQuerieButton.TextAlignment = Terminal.Gui.Alignment.Center;
            this.publicFigureQuerieButton.IsDefault = false;
            this.queriesWindow.Add(this.publicFigureQuerieButton);
            this.outputWindow.Width = Dim.Fill(0);
            this.outputWindow.Height = Dim.Fill(0);
            this.outputWindow.X = Pos.Right(queriesWindow);
            this.outputWindow.Y = 0;
            this.outputWindow.Visible = true;
            this.outputWindow.Arrangement = (Terminal.Gui.ViewArrangement.Movable | Terminal.Gui.ViewArrangement.Overlapped);
            this.outputWindow.Modal = false;
            this.outputWindow.Data = "outputWindow";
            this.outputWindow.TextAlignment = Terminal.Gui.Alignment.Start;
            this.outputWindow.Title = "Output";
            this.Add(this.outputWindow);
            this.outputListView.Width = Dim.Fill(0);
            this.outputListView.Height = Dim.Fill(0);
            this.outputListView.X = Pos.Center();
            this.outputListView.Y = Pos.Center();
            this.outputListView.Visible = true;
            this.outputListView.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.outputListView.Data = "outputListView";
            this.outputListView.TextAlignment = Terminal.Gui.Alignment.Start;
            this.outputListView.Source = new Terminal.Gui.ListWrapper<string>(new System.Collections.ObjectModel.ObservableCollection<string>(new string[] {
                            "Item1",
                            "Item2",
                            "Item3"}));
            this.outputListView.AllowsMarking = false;
            this.outputListView.AllowsMultipleSelection = true;
            this.outputWindow.Add(this.outputListView);
            this.optionWindow.Width = Dim.Percent(50);
            this.optionWindow.Height = Dim.Fill(0);
            this.optionWindow.X = 0;
            this.optionWindow.Y = Pos.Bottom(queriesWindow);
            this.optionWindow.Visible = true;
            this.optionWindow.Arrangement = (Terminal.Gui.ViewArrangement.Movable | Terminal.Gui.ViewArrangement.Overlapped);
            this.optionWindow.Modal = false;
            this.optionWindow.Data = "optionWindow";
            this.optionWindow.TextAlignment = Terminal.Gui.Alignment.Start;
            this.optionWindow.Title = "";
            this.Add(this.optionWindow);
            this.backButton.Width = Dim.Auto();
            this.backButton.Height = 1;
            this.backButton.X = Pos.Center();
            this.backButton.Y = Pos.Center();
            this.backButton.Visible = true;
            this.backButton.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.backButton.Data = "backButton";
            this.backButton.Text = "Back";
            this.backButton.TextAlignment = Terminal.Gui.Alignment.Center;
            this.backButton.IsDefault = false;
            this.optionWindow.Add(this.backButton);
        }
    }
}
