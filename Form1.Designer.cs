
namespace AvereageByRegion
{
    partial class formAverageByRegion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelCases = new System.Windows.Forms.Label();
            this.textBoxUnitsEntry = new System.Windows.Forms.TextBox();
            this.labelDays = new System.Windows.Forms.Label();
            this.labelRegion1Prompt = new System.Windows.Forms.Label();
            this.labelRegion2Prompt = new System.Windows.Forms.Label();
            this.labelRegion3Prompt = new System.Windows.Forms.Label();
            this.textBoxRegion1List = new System.Windows.Forms.TextBox();
            this.textBoxRegion2List = new System.Windows.Forms.TextBox();
            this.textBoxRegion3List = new System.Windows.Forms.TextBox();
            this.labelRegion1Average = new System.Windows.Forms.Label();
            this.labelRegion2Average = new System.Windows.Forms.Label();
            this.labelRegion3Average = new System.Windows.Forms.Label();
            this.labelAverageOutput = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelCases
            // 
            this.labelCases.Location = new System.Drawing.Point(42, 24);
            this.labelCases.Name = "labelCases";
            this.labelCases.Size = new System.Drawing.Size(100, 23);
            this.labelCases.TabIndex = 0;
            this.labelCases.Text = "&Cases:";
            // 
            // textBoxUnitsEntry
            // 
            this.textBoxUnitsEntry.Location = new System.Drawing.Point(85, 21);
            this.textBoxUnitsEntry.Name = "textBoxUnitsEntry";
            this.textBoxUnitsEntry.Size = new System.Drawing.Size(104, 23);
            this.textBoxUnitsEntry.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBoxUnitsEntry, "Enter unit");
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Location = new System.Drawing.Point(306, 24);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(36, 15);
            this.labelDays.TabIndex = 2;
            this.labelDays.Text = "Day 1";
            this.toolTip1.SetToolTip(this.labelDays, "Displays the day of the region");
            // 
            // labelRegion1Prompt
            // 
            this.labelRegion1Prompt.AutoSize = true;
            this.labelRegion1Prompt.Location = new System.Drawing.Point(41, 97);
            this.labelRegion1Prompt.Name = "labelRegion1Prompt";
            this.labelRegion1Prompt.Size = new System.Drawing.Size(53, 15);
            this.labelRegion1Prompt.TabIndex = 3;
            this.labelRegion1Prompt.Text = "Region &1";
            // 
            // labelRegion2Prompt
            // 
            this.labelRegion2Prompt.AutoSize = true;
            this.labelRegion2Prompt.Location = new System.Drawing.Point(190, 97);
            this.labelRegion2Prompt.Name = "labelRegion2Prompt";
            this.labelRegion2Prompt.Size = new System.Drawing.Size(53, 15);
            this.labelRegion2Prompt.TabIndex = 4;
            this.labelRegion2Prompt.Text = "Region &2";
            // 
            // labelRegion3Prompt
            // 
            this.labelRegion3Prompt.AutoSize = true;
            this.labelRegion3Prompt.Location = new System.Drawing.Point(332, 97);
            this.labelRegion3Prompt.Name = "labelRegion3Prompt";
            this.labelRegion3Prompt.Size = new System.Drawing.Size(53, 15);
            this.labelRegion3Prompt.TabIndex = 5;
            this.labelRegion3Prompt.Text = "Region &3";
            // 
            // textBoxRegion1List
            // 
            this.textBoxRegion1List.Location = new System.Drawing.Point(19, 125);
            this.textBoxRegion1List.Multiline = true;
            this.textBoxRegion1List.Name = "textBoxRegion1List";
            this.textBoxRegion1List.ReadOnly = true;
            this.textBoxRegion1List.Size = new System.Drawing.Size(101, 137);
            this.textBoxRegion1List.TabIndex = 6;
            this.toolTip1.SetToolTip(this.textBoxRegion1List, "Displays the entered unit for region 1");
            // 
            // textBoxRegion2List
            // 
            this.textBoxRegion2List.Location = new System.Drawing.Point(164, 125);
            this.textBoxRegion2List.Multiline = true;
            this.textBoxRegion2List.Name = "textBoxRegion2List";
            this.textBoxRegion2List.ReadOnly = true;
            this.textBoxRegion2List.Size = new System.Drawing.Size(101, 137);
            this.textBoxRegion2List.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBoxRegion2List, "Displays the entered units for region 2");
            // 
            // textBoxRegion3List
            // 
            this.textBoxRegion3List.Location = new System.Drawing.Point(306, 125);
            this.textBoxRegion3List.Multiline = true;
            this.textBoxRegion3List.Name = "textBoxRegion3List";
            this.textBoxRegion3List.ReadOnly = true;
            this.textBoxRegion3List.Size = new System.Drawing.Size(101, 137);
            this.textBoxRegion3List.TabIndex = 8;
            this.toolTip1.SetToolTip(this.textBoxRegion3List, "Displays the entered units for region 3");
            // 
            // labelRegion1Average
            // 
            this.labelRegion1Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRegion1Average.Location = new System.Drawing.Point(17, 277);
            this.labelRegion1Average.Name = "labelRegion1Average";
            this.labelRegion1Average.Size = new System.Drawing.Size(103, 31);
            this.labelRegion1Average.TabIndex = 9;
            this.labelRegion1Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelRegion1Average, "Displays the average for region 1");
            // 
            // labelRegion2Average
            // 
            this.labelRegion2Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRegion2Average.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelRegion2Average.Location = new System.Drawing.Point(164, 277);
            this.labelRegion2Average.Name = "labelRegion2Average";
            this.labelRegion2Average.Size = new System.Drawing.Size(103, 31);
            this.labelRegion2Average.TabIndex = 10;
            this.labelRegion2Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelRegion2Average, "Displays the average for region 2");
            // 
            // labelRegion3Average
            // 
            this.labelRegion3Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRegion3Average.Location = new System.Drawing.Point(317, 277);
            this.labelRegion3Average.Name = "labelRegion3Average";
            this.labelRegion3Average.Size = new System.Drawing.Size(103, 31);
            this.labelRegion3Average.TabIndex = 11;
            this.labelRegion3Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelRegion3Average, "Displays the average for region 3");
            // 
            // labelAverageOutput
            // 
            this.labelAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageOutput.Location = new System.Drawing.Point(17, 325);
            this.labelAverageOutput.Name = "labelAverageOutput";
            this.labelAverageOutput.Size = new System.Drawing.Size(403, 23);
            this.labelAverageOutput.TabIndex = 12;
            this.labelAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelAverageOutput, "Displays the overall average of all 3 regions");
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(19, 351);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 23);
            this.buttonEnter.TabIndex = 13;
            this.buttonEnter.Tag = "";
            this.buttonEnter.Text = "&Enter";
            this.toolTip1.SetToolTip(this.buttonEnter, "Press to enter the units");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.EnterClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(177, 351);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.buttonReset, "Press to reset the form");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ResetClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(332, 351);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.buttonExit, "Press to exit the program");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // formAverageByRegion
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(443, 386);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelAverageOutput);
            this.Controls.Add(this.labelRegion3Average);
            this.Controls.Add(this.labelRegion2Average);
            this.Controls.Add(this.labelRegion1Average);
            this.Controls.Add(this.textBoxRegion3List);
            this.Controls.Add(this.textBoxRegion2List);
            this.Controls.Add(this.textBoxRegion1List);
            this.Controls.Add(this.labelRegion3Prompt);
            this.Controls.Add(this.labelRegion2Prompt);
            this.Controls.Add(this.labelRegion1Prompt);
            this.Controls.Add(this.labelDays);
            this.Controls.Add(this.textBoxUnitsEntry);
            this.Controls.Add(this.labelCases);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAverageByRegion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Weekly Units by Region";
            this.Load += new System.EventHandler(this.formAverageByRegion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCases;
        private System.Windows.Forms.TextBox textBoxUnitsEntry;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.Label labelRegion1Prompt;
        private System.Windows.Forms.Label labelRegion2Prompt;
        private System.Windows.Forms.Label labelRegion3Prompt;
        private System.Windows.Forms.TextBox textBoxRegion1List;
        private System.Windows.Forms.TextBox textBoxRegion2List;
        private System.Windows.Forms.TextBox textBoxRegion3List;
        private System.Windows.Forms.Label labelRegion1Average;
        private System.Windows.Forms.Label labelRegion2Average;
        private System.Windows.Forms.Label labelRegion3Average;
        private System.Windows.Forms.Label labelAverageOutput;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

