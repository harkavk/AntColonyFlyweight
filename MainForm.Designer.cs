namespace AntColonyFlyweight
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel pnlField;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTypes;
        private System.Windows.Forms.Label lblLegend;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.Button btnAddSoldier;
        private System.Windows.Forms.Button btnAddScout;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Timer timer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.btnAddSoldier = new System.Windows.Forms.Button();
            this.btnAddScout = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTypes = new System.Windows.Forms.Label();
            this.lblLegend = new System.Windows.Forms.Label();
            this.pnlField = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.pnlControls.Controls.Add(this.btnAddWorker);
            this.pnlControls.Controls.Add(this.btnAddSoldier);
            this.pnlControls.Controls.Add(this.btnAddScout);
            this.pnlControls.Controls.Add(this.btnStart);
            this.pnlControls.Controls.Add(this.btnClear);
            this.pnlControls.Controls.Add(this.lblTotal);
            this.pnlControls.Controls.Add(this.lblTypes);
            this.pnlControls.Controls.Add(this.lblLegend);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Padding = new System.Windows.Forms.Padding(24, 14, 24, 12);
            this.pnlControls.Size = new System.Drawing.Size(1000, 115);
            this.pnlControls.TabIndex = 1;
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.BackColor = System.Drawing.Color.White;
            this.btnAddWorker.FlatAppearance.BorderSize = 0;
            this.btnAddWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWorker.ForeColor = System.Drawing.Color.Black;
            this.btnAddWorker.Location = new System.Drawing.Point(28, 15);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(125, 34);
            this.btnAddWorker.TabIndex = 0;
            this.btnAddWorker.Text = "+ Робоча";
            this.btnAddWorker.UseVisualStyleBackColor = false;
            // 
            // btnAddSoldier
            // 
            this.btnAddSoldier.BackColor = System.Drawing.Color.White;
            this.btnAddSoldier.FlatAppearance.BorderSize = 0;
            this.btnAddSoldier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSoldier.ForeColor = System.Drawing.Color.Black;
            this.btnAddSoldier.Location = new System.Drawing.Point(162, 15);
            this.btnAddSoldier.Name = "btnAddSoldier";
            this.btnAddSoldier.Size = new System.Drawing.Size(125, 34);
            this.btnAddSoldier.TabIndex = 1;
            this.btnAddSoldier.Text = "+ Солдат";
            this.btnAddSoldier.UseVisualStyleBackColor = false;
            // 
            // btnAddScout
            // 
            this.btnAddScout.BackColor = System.Drawing.Color.White;
            this.btnAddScout.FlatAppearance.BorderSize = 0;
            this.btnAddScout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddScout.ForeColor = System.Drawing.Color.Black;
            this.btnAddScout.Location = new System.Drawing.Point(296, 15);
            this.btnAddScout.Name = "btnAddScout";
            this.btnAddScout.Size = new System.Drawing.Size(125, 34);
            this.btnAddScout.TabIndex = 2;
            this.btnAddScout.Text = "+ Розвідник";
            this.btnAddScout.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(445, 15);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(125, 34);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Почати рух";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(222)))), ((int)(((byte)(232)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(579, 15);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 34);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(80)))));
            this.lblTotal.Location = new System.Drawing.Point(28, 68);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(73, 15);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Мурашок: 0";
            // 
            // lblTypes
            // 
            this.lblTypes.AutoSize = true;
            this.lblTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(80)))));
            this.lblTypes.Location = new System.Drawing.Point(160, 68);
            this.lblTypes.Name = "lblTypes";
            this.lblTypes.Size = new System.Drawing.Size(100, 15);
            this.lblTypes.TabIndex = 6;
            this.lblTypes.Text = "Спільних типів: 0";
            // 
            // lblLegend
            // 
            this.lblLegend.AutoSize = true;
            this.lblLegend.ForeColor = System.Drawing.Color.Gray;
            this.lblLegend.Location = new System.Drawing.Point(340, 68);
            this.lblLegend.Name = "lblLegend";
            this.lblLegend.Size = new System.Drawing.Size(0, 15);
            this.lblLegend.TabIndex = 7;
            // 
            // pnlField
            // 
            this.pnlField.BackColor = System.Drawing.Color.White;
            this.pnlField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlField.Location = new System.Drawing.Point(0, 115);
            this.pnlField.Margin = new System.Windows.Forms.Padding(24);
            this.pnlField.Name = "pnlField";
            this.pnlField.Padding = new System.Windows.Forms.Padding(10);
            this.pnlField.Size = new System.Drawing.Size(1000, 535);
            this.pnlField.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.pnlField);
            this.Controls.Add(this.pnlControls);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(850, 550);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Імітація руху мурашок";
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
