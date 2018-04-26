﻿namespace dbcvalue
{
    partial class FrmDBC
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grpMessage = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numByte0 = new System.Windows.Forms.NumericUpDown();
            this.cmbByteOrder = new System.Windows.Forms.ComboBox();
            this.dgvLayout = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numStartBit = new System.Windows.Forms.NumericUpDown();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.grpMessage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numByte0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartBit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMessage
            // 
            this.grpMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMessage.Controls.Add(this.dgvLayout);
            this.grpMessage.Controls.Add(this.cmbByteOrder);
            this.grpMessage.Controls.Add(this.numByte0);
            this.grpMessage.Controls.Add(this.label4);
            this.grpMessage.Controls.Add(this.label3);
            this.grpMessage.Controls.Add(this.lblData);
            this.grpMessage.Location = new System.Drawing.Point(12, 12);
            this.grpMessage.Name = "grpMessage";
            this.grpMessage.Size = new System.Drawing.Size(667, 292);
            this.grpMessage.TabIndex = 0;
            this.grpMessage.TabStop = false;
            this.grpMessage.Text = "Message";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtValue);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numLength);
            this.groupBox2.Controls.Add(this.numStartBit);
            this.groupBox2.Location = new System.Drawing.Point(12, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 138);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Signal";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(16, 60);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(35, 12);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "ByteOrder:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Layout:";
            // 
            // numByte0
            // 
            this.numByte0.Location = new System.Drawing.Point(87, 58);
            this.numByte0.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numByte0.Name = "numByte0";
            this.numByte0.Size = new System.Drawing.Size(53, 21);
            this.numByte0.TabIndex = 4;
            this.numByte0.ValueChanged += new System.EventHandler(this.numByte0_ValueChanged);
            // 
            // cmbByteOrder
            // 
            this.cmbByteOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbByteOrder.FormattingEnabled = true;
            this.cmbByteOrder.Items.AddRange(new object[] {
            "MSB",
            "LSB"});
            this.cmbByteOrder.Location = new System.Drawing.Point(87, 26);
            this.cmbByteOrder.Name = "cmbByteOrder";
            this.cmbByteOrder.Size = new System.Drawing.Size(53, 20);
            this.cmbByteOrder.TabIndex = 5;
            this.cmbByteOrder.SelectedIndexChanged += new System.EventHandler(this.cmbByteOrder_SelectedIndexChanged);
            // 
            // dgvLayout
            // 
            this.dgvLayout.AllowUserToAddRows = false;
            this.dgvLayout.AllowUserToDeleteRows = false;
            this.dgvLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLayout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLayout.Location = new System.Drawing.Point(87, 88);
            this.dgvLayout.Name = "dgvLayout";
            this.dgvLayout.ReadOnly = true;
            this.dgvLayout.RowTemplate.Height = 23;
            this.dgvLayout.Size = new System.Drawing.Size(574, 198);
            this.dgvLayout.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "StartBit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Length:";
            // 
            // numStartBit
            // 
            this.numStartBit.Location = new System.Drawing.Point(81, 29);
            this.numStartBit.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numStartBit.Name = "numStartBit";
            this.numStartBit.Size = new System.Drawing.Size(53, 21);
            this.numStartBit.TabIndex = 4;
            this.numStartBit.ValueChanged += new System.EventHandler(this.numStartBit_ValueChanged);
            // 
            // numLength
            // 
            this.numLength.Location = new System.Drawing.Point(81, 61);
            this.numLength.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(53, 21);
            this.numLength.TabIndex = 4;
            this.numLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLength.ValueChanged += new System.EventHandler(this.numStartBit_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "Value:";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(81, 92);
            this.txtValue.Name = "txtValue";
            this.txtValue.ReadOnly = true;
            this.txtValue.Size = new System.Drawing.Size(100, 21);
            this.txtValue.TabIndex = 6;
            // 
            // FrmDBC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 460);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpMessage);
            this.Name = "FrmDBC";
            this.Text = "dbcvalue";
            this.Load += new System.EventHandler(this.FrmDBC_Load);
            this.grpMessage.ResumeLayout(false);
            this.grpMessage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numByte0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartBit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMessage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numByte0;
        private System.Windows.Forms.ComboBox cmbByteOrder;
        private System.Windows.Forms.DataGridView dgvLayout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numStartBit;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValue;
    }
}

