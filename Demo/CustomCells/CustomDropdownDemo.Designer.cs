/*****************************************************************************
 * 
 * ReoGrid - .NET Spreadsheet Control
 * 
 * http://reogrid.net
 *
 * THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
 * KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
 * PURPOSE.
 *
 * ReoGrid and ReoGrid Demo project is released under MIT license.
 *
 * Copyright (c) 2012-2016 Jing <lujing at unvell.com>
 * Copyright (c) 2012-2016 unvell.com, all rights reserved.
 * 
 ****************************************************************************/

namespace unvell.ReoGrid.Demo.CustomCells
{
	partial class CustomDropdownDemo
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.grid = new unvell.ReoGrid.ReoGridControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkGridlines = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid.ColumnHeaderContextMenuStrip = null;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.LeadHeaderContextMenuStrip = null;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Name = "grid";
            this.grid.RowHeaderContextMenuStrip = null;
            this.grid.Script = null;
            this.grid.SheetTabContextMenuStrip = null;
            this.grid.SheetTabNewButtonVisible = true;
            this.grid.SheetTabVisible = true;
            this.grid.SheetTabWidth = 400;
            this.grid.ShowScrollEndSpacing = true;
            this.grid.Size = new System.Drawing.Size(751, 500);
            this.grid.TabIndex = 2;
            this.grid.Text = "reoGridControl1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.chkGridlines);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(751, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 500);
            this.panel1.TabIndex = 3;
            // 
            // chkGridlines
            // 
            this.chkGridlines.AutoSize = true;
            this.chkGridlines.Checked = true;
            this.chkGridlines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGridlines.Location = new System.Drawing.Point(16, 20);
            this.chkGridlines.Name = "chkGridlines";
            this.chkGridlines.Size = new System.Drawing.Size(84, 16);
            this.chkGridlines.TabIndex = 0;
            this.chkGridlines.Text = "Grid lines";
            this.chkGridlines.UseVisualStyleBackColor = true;
            this.chkGridlines.CheckedChanged += new System.EventHandler(this.chkGridlines_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomDropdownDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel1);
            this.Name = "CustomDropdownDemo";
            this.Size = new System.Drawing.Size(874, 500);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private ReoGridControl grid;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox chkGridlines;
        private System.Windows.Forms.Button button1;
    }
}