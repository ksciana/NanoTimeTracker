﻿/*
Nano TimeTracker - a small free windows time-tracking utility
Copyright (C) 2011 Tao Klerks

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.

 */

using System;
using System.Drawing;
using System.Windows.Forms;


namespace NanoTimeTracker
{
    partial class LogWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.timer_StatusUpdate = new System.Windows.Forms.Timer(this.components);
            this.txt_LogBox = new System.Windows.Forms.TextBox();
            this.lbl_WorkingTimeValue = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu_SysTrayContext = new System.Windows.Forms.ContextMenu();
            this.menuItem_StartCounting = new System.Windows.Forms.MenuItem();
            this.menuItem_StopCounting = new System.Windows.Forms.MenuItem();
            this.menuItem_Quit = new System.Windows.Forms.MenuItem();
            this.timer_NotifySingleClick = new System.Windows.Forms.Timer(this.components);
            this.dataGridView_TaskLogList = new System.Windows.Forms.DataGridView();
            this.StartDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Billable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TimeTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new NanoTimeTracker.DataSet1();
            this.lbl_TimeTodayValue = new System.Windows.Forms.Label();
            this.lbl_BillableTimeTodayValue = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_WorkingTimeLabel = new System.Windows.Forms.Label();
            this.lbl_BillableTodayLabel = new System.Windows.Forms.Label();
            this.lbl_TimeTodayLabel = new System.Windows.Forms.Label();
            this.grp_Status = new System.Windows.Forms.GroupBox();
            this.onlineHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TaskLogList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grp_Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(532, 375);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(106, 37);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(532, 417);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(106, 37);
            this.btn_Stop.TabIndex = 1;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // timer_StatusUpdate
            // 
            this.timer_StatusUpdate.Interval = 1000;
            this.timer_StatusUpdate.Tick += new System.EventHandler(this.timer_StatusUpdate_Tick);
            // 
            // txt_LogBox
            // 
            this.txt_LogBox.AcceptsReturn = true;
            this.txt_LogBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_LogBox.Location = new System.Drawing.Point(198, 12);
            this.txt_LogBox.Multiline = true;
            this.txt_LogBox.Name = "txt_LogBox";
            this.txt_LogBox.ReadOnly = true;
            this.txt_LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_LogBox.Size = new System.Drawing.Size(314, 82);
            this.txt_LogBox.TabIndex = 2;
            // 
            // lbl_WorkingTimeValue
            // 
            this.lbl_WorkingTimeValue.AutoSize = true;
            this.lbl_WorkingTimeValue.Location = new System.Drawing.Point(112, 23);
            this.lbl_WorkingTimeValue.Name = "lbl_WorkingTimeValue";
            this.lbl_WorkingTimeValue.Size = new System.Drawing.Size(53, 13);
            this.lbl_WorkingTimeValue.TabIndex = 3;
            this.lbl_WorkingTimeValue.Text = "working...";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenu = this.contextMenu_SysTrayContext;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Time Logger";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            this.notifyIcon1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDown);
            // 
            // contextMenu_SysTrayContext
            // 
            this.contextMenu_SysTrayContext.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_StartCounting,
            this.menuItem_StopCounting,
            this.menuItem_Quit});
            // 
            // menuItem_StartCounting
            // 
            this.menuItem_StartCounting.Index = 0;
            this.menuItem_StartCounting.Text = "Start Counting";
            this.menuItem_StartCounting.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // menuItem_StopCounting
            // 
            this.menuItem_StopCounting.Enabled = false;
            this.menuItem_StopCounting.Index = 1;
            this.menuItem_StopCounting.Text = "Stop Counting";
            this.menuItem_StopCounting.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // menuItem_Quit
            // 
            this.menuItem_Quit.Index = 2;
            this.menuItem_Quit.Text = "Quit";
            this.menuItem_Quit.Click += new System.EventHandler(this.menuItem_Quit_Click);
            // 
            // timer_NotifySingleClick
            // 
            this.timer_NotifySingleClick.Interval = 500;
            this.timer_NotifySingleClick.Tick += new System.EventHandler(this.timer_NotifySingleClick_Tick);
            // 
            // dataGridView_TaskLogList
            // 
            this.dataGridView_TaskLogList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_TaskLogList.AutoGenerateColumns = false;
            this.dataGridView_TaskLogList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TaskLogList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartDateTime,
            this.EndDateTime,
            this.TaskName,
            this.Billable,
            this.TimeTaken});
            this.dataGridView_TaskLogList.DataMember = "DataTable1";
            this.dataGridView_TaskLogList.DataSource = this.dataSet1BindingSource;
            this.dataGridView_TaskLogList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView_TaskLogList.Location = new System.Drawing.Point(8, 27);
            this.dataGridView_TaskLogList.Name = "dataGridView_TaskLogList";
            this.dataGridView_TaskLogList.Size = new System.Drawing.Size(638, 331);
            this.dataGridView_TaskLogList.TabIndex = 6;
            this.dataGridView_TaskLogList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_TaskLogList_CellValueChanged);
            // 
            // StartDateTime
            // 
            this.StartDateTime.DataPropertyName = "StartDateTime";
            this.StartDateTime.HeaderText = "StartDateTime";
            this.StartDateTime.Name = "StartDateTime";
            this.StartDateTime.Width = 130;
            // 
            // EndDateTime
            // 
            this.EndDateTime.DataPropertyName = "EndDateTime";
            this.EndDateTime.HeaderText = "EndDateTime";
            this.EndDateTime.Name = "EndDateTime";
            this.EndDateTime.Width = 130;
            // 
            // TaskName
            // 
            this.TaskName.DataPropertyName = "TaskName";
            this.TaskName.HeaderText = "TaskName";
            this.TaskName.Name = "TaskName";
            this.TaskName.Width = 200;
            // 
            // Billable
            // 
            this.Billable.DataPropertyName = "BillableFlag";
            this.Billable.HeaderText = "Billable";
            this.Billable.Name = "Billable";
            this.Billable.Width = 50;
            // 
            // TimeTaken
            // 
            this.TimeTaken.DataPropertyName = "TimeTaken";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.TimeTaken.DefaultCellStyle = dataGridViewCellStyle4;
            this.TimeTaken.HeaderText = "TimeTaken";
            this.TimeTaken.Name = "TimeTaken";
            this.TimeTaken.Width = 80;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_TimeTodayValue
            // 
            this.lbl_TimeTodayValue.AutoSize = true;
            this.lbl_TimeTodayValue.Location = new System.Drawing.Point(112, 46);
            this.lbl_TimeTodayValue.Name = "lbl_TimeTodayValue";
            this.lbl_TimeTodayValue.Size = new System.Drawing.Size(53, 13);
            this.lbl_TimeTodayValue.TabIndex = 7;
            this.lbl_TimeTodayValue.Text = "working...";
            // 
            // lbl_BillableTimeTodayValue
            // 
            this.lbl_BillableTimeTodayValue.AutoSize = true;
            this.lbl_BillableTimeTodayValue.Location = new System.Drawing.Point(112, 69);
            this.lbl_BillableTimeTodayValue.Name = "lbl_BillableTimeTodayValue";
            this.lbl_BillableTimeTodayValue.Size = new System.Drawing.Size(53, 13);
            this.lbl_BillableTimeTodayValue.TabIndex = 8;
            this.lbl_BillableTimeTodayValue.Text = "working...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(654, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "Options...";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteLogToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // deleteLogToolStripMenuItem
            // 
            this.deleteLogToolStripMenuItem.Name = "deleteLogToolStripMenuItem";
            this.deleteLogToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteLogToolStripMenuItem.Text = "Delete Log...";
            this.deleteLogToolStripMenuItem.Click += new System.EventHandler(this.deleteLogToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlineHelpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // lbl_WorkingTimeLabel
            // 
            this.lbl_WorkingTimeLabel.AutoSize = true;
            this.lbl_WorkingTimeLabel.Location = new System.Drawing.Point(6, 23);
            this.lbl_WorkingTimeLabel.Name = "lbl_WorkingTimeLabel";
            this.lbl_WorkingTimeLabel.Size = new System.Drawing.Size(60, 13);
            this.lbl_WorkingTimeLabel.TabIndex = 10;
            this.lbl_WorkingTimeLabel.Text = "Task Time:";
            // 
            // lbl_BillableTodayLabel
            // 
            this.lbl_BillableTodayLabel.AutoSize = true;
            this.lbl_BillableTodayLabel.Location = new System.Drawing.Point(6, 69);
            this.lbl_BillableTodayLabel.Name = "lbl_BillableTodayLabel";
            this.lbl_BillableTodayLabel.Size = new System.Drawing.Size(102, 13);
            this.lbl_BillableTodayLabel.TabIndex = 12;
            this.lbl_BillableTodayLabel.Text = "Billable Time Today:";
            // 
            // lbl_TimeTodayLabel
            // 
            this.lbl_TimeTodayLabel.AutoSize = true;
            this.lbl_TimeTodayLabel.Location = new System.Drawing.Point(6, 46);
            this.lbl_TimeTodayLabel.Name = "lbl_TimeTodayLabel";
            this.lbl_TimeTodayLabel.Size = new System.Drawing.Size(66, 13);
            this.lbl_TimeTodayLabel.TabIndex = 11;
            this.lbl_TimeTodayLabel.Text = "Time Today:";
            // 
            // grp_Status
            // 
            this.grp_Status.Controls.Add(this.lbl_BillableTodayLabel);
            this.grp_Status.Controls.Add(this.lbl_WorkingTimeLabel);
            this.grp_Status.Controls.Add(this.lbl_BillableTimeTodayValue);
            this.grp_Status.Controls.Add(this.lbl_WorkingTimeValue);
            this.grp_Status.Controls.Add(this.txt_LogBox);
            this.grp_Status.Controls.Add(this.lbl_TimeTodayLabel);
            this.grp_Status.Controls.Add(this.lbl_TimeTodayValue);
            this.grp_Status.Location = new System.Drawing.Point(8, 364);
            this.grp_Status.Name = "grp_Status";
            this.grp_Status.Size = new System.Drawing.Size(518, 100);
            this.grp_Status.TabIndex = 12;
            this.grp_Status.TabStop = false;
            this.grp_Status.Text = "Status";
            // 
            // onlineHelpToolStripMenuItem
            // 
            this.onlineHelpToolStripMenuItem.Name = "onlineHelpToolStripMenuItem";
            this.onlineHelpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.onlineHelpToolStripMenuItem.Text = "Online Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // LogWindow
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(654, 476);
            this.Controls.Add(this.grp_Status);
            this.Controls.Add(this.dataGridView_TaskLogList);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LogWindow";
            this.Text = "LogWindow";
            this.Load += new System.EventHandler(this.LogWindow_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.LogWindow_Closing);
            this.Resize += new System.EventHandler(this.LogWindow_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TaskLogList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grp_Status.ResumeLayout(false);
            this.grp_Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Button btn_Start;
        private Button btn_Stop;
        private TextBox txt_LogBox;
        private Label lbl_WorkingTimeValue;
        private Label lbl_TimeTodayValue;
        private Label lbl_BillableTimeTodayValue;
        private NotifyIcon notifyIcon1;
        private ContextMenu contextMenu_SysTrayContext;
        private MenuItem menuItem_StartCounting;
        private MenuItem menuItem_StopCounting;
        private MenuItem menuItem_Quit;
        private Timer timer_StatusUpdate;
        private Timer timer_NotifySingleClick;
        private DataGridView dataGridView_TaskLogList;
        private BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private DataGridViewTextBoxColumn StartDateTime;
        private DataGridViewTextBoxColumn EndDateTime;
        private DataGridViewTextBoxColumn TaskName;
        private DataGridViewCheckBoxColumn Billable;
        private DataGridViewTextBoxColumn TimeTaken;
        private MenuStrip menuStrip1;
        private Label lbl_WorkingTimeLabel;
        private Label lbl_TimeTodayLabel;
        private Label lbl_BillableTodayLabel;
        private GroupBox grp_Status;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem deleteLogToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem onlineHelpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}

