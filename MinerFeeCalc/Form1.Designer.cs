namespace MinerFeeCalc
{
    partial class Main
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBytes = new System.Windows.Forms.TextBox();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvSelectedTrans = new System.Windows.Forms.DataGridView();
            this.lblTotalRew = new System.Windows.Forms.Label();
            this.txtTotalReward = new System.Windows.Forms.Label();
            this.lblBlockRew = new System.Windows.Forms.Label();
            this.txtBlockReward = new System.Windows.Forms.Label();
            this.lblBlockSiz = new System.Windows.Forms.Label();
            this.txtBlockSize = new System.Windows.Forms.Label();
            this.lbltrasnsSelected = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbltrananslist = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedTrans)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvTransactions, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dgvSelectedTrans, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCalculate, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtFee, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBytes, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalRew, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBlockRew, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBlockSiz, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTotalReward, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBlockReward, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBlockSize, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbltrasnsSelected, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbltrananslist, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(802, 455);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvTransactions, 3);
            this.dgvTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransactions.Location = new System.Drawing.Point(2, 132);
            this.dgvTransactions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.RowHeadersWidth = 62;
            this.dgvTransactions.RowTemplate.Height = 28;
            this.dgvTransactions.Size = new System.Drawing.Size(347, 321);
            this.dgvTransactions.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bytes";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fee";
            // 
            // txtBytes
            // 
            this.txtBytes.Location = new System.Drawing.Point(8, 47);
            this.txtBytes.Margin = new System.Windows.Forms.Padding(8, 2, 2, 2);
            this.txtBytes.Name = "txtBytes";
            this.txtBytes.Size = new System.Drawing.Size(105, 20);
            this.txtBytes.TabIndex = 2;
            this.txtBytes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBytes_KeyPress);
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(122, 47);
            this.txtFee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(106, 20);
            this.txtFee.TabIndex = 3;
            this.txtFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFee_KeyPress);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCalculate.Location = new System.Drawing.Point(353, 72);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(96, 36);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate Total Reward";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(122, 72);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 25);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // dgvSelectedTrans
            // 
            this.dgvSelectedTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvSelectedTrans, 3);
            this.dgvSelectedTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectedTrans.Location = new System.Drawing.Point(453, 132);
            this.dgvSelectedTrans.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSelectedTrans.Name = "dgvSelectedTrans";
            this.dgvSelectedTrans.RowHeadersWidth = 62;
            this.dgvSelectedTrans.RowTemplate.Height = 28;
            this.dgvSelectedTrans.Size = new System.Drawing.Size(347, 321);
            this.dgvSelectedTrans.TabIndex = 11;
            // 
            // lblTotalRew
            // 
            this.lblTotalRew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalRew.AutoSize = true;
            this.lblTotalRew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRew.Location = new System.Drawing.Point(693, 32);
            this.lblTotalRew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalRew.Name = "lblTotalRew";
            this.lblTotalRew.Size = new System.Drawing.Size(83, 13);
            this.lblTotalRew.TabIndex = 8;
            this.lblTotalRew.Text = "Total Reward";
            // 
            // txtTotalReward
            // 
            this.txtTotalReward.AutoSize = true;
            this.txtTotalReward.BackColor = System.Drawing.Color.DarkTurquoise;
            this.txtTotalReward.Location = new System.Drawing.Point(694, 48);
            this.txtTotalReward.Margin = new System.Windows.Forms.Padding(3);
            this.txtTotalReward.Name = "txtTotalReward";
            this.txtTotalReward.Padding = new System.Windows.Forms.Padding(2);
            this.txtTotalReward.Size = new System.Drawing.Size(17, 17);
            this.txtTotalReward.TabIndex = 10;
            this.txtTotalReward.Text = "0";
            // 
            // lblBlockRew
            // 
            this.lblBlockRew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBlockRew.AutoSize = true;
            this.lblBlockRew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlockRew.Location = new System.Drawing.Point(573, 32);
            this.lblBlockRew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBlockRew.Name = "lblBlockRew";
            this.lblBlockRew.Size = new System.Drawing.Size(81, 13);
            this.lblBlockRew.TabIndex = 7;
            this.lblBlockRew.Text = "Block reward";
            // 
            // txtBlockReward
            // 
            this.txtBlockReward.AutoSize = true;
            this.txtBlockReward.BackColor = System.Drawing.Color.LightBlue;
            this.txtBlockReward.Location = new System.Drawing.Point(574, 48);
            this.txtBlockReward.Margin = new System.Windows.Forms.Padding(3);
            this.txtBlockReward.Name = "txtBlockReward";
            this.txtBlockReward.Padding = new System.Windows.Forms.Padding(2);
            this.txtBlockReward.Size = new System.Drawing.Size(32, 17);
            this.txtBlockReward.TabIndex = 9;
            this.txtBlockReward.Text = "12.5";
            // 
            // lblBlockSiz
            // 
            this.lblBlockSiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBlockSiz.AutoSize = true;
            this.lblBlockSiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlockSiz.Location = new System.Drawing.Point(453, 32);
            this.lblBlockSiz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBlockSiz.Name = "lblBlockSiz";
            this.lblBlockSiz.Size = new System.Drawing.Size(67, 13);
            this.lblBlockSiz.TabIndex = 12;
            this.lblBlockSiz.Text = "Block Size";
            // 
            // txtBlockSize
            // 
            this.txtBlockSize.AutoSize = true;
            this.txtBlockSize.BackColor = System.Drawing.Color.LightBlue;
            this.txtBlockSize.Location = new System.Drawing.Point(454, 48);
            this.txtBlockSize.Margin = new System.Windows.Forms.Padding(3);
            this.txtBlockSize.Name = "txtBlockSize";
            this.txtBlockSize.Padding = new System.Windows.Forms.Padding(2);
            this.txtBlockSize.Size = new System.Drawing.Size(47, 17);
            this.txtBlockSize.TabIndex = 13;
            this.txtBlockSize.Text = "500000";
            // 
            // lbltrasnsSelected
            // 
            this.lbltrasnsSelected.AutoSize = true;
            this.lbltrasnsSelected.BackColor = System.Drawing.Color.PapayaWhip;
            this.tableLayoutPanel1.SetColumnSpan(this.lbltrasnsSelected, 3);
            this.lbltrasnsSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrasnsSelected.Location = new System.Drawing.Point(454, 110);
            this.lbltrasnsSelected.Name = "lbltrasnsSelected";
            this.lbltrasnsSelected.Size = new System.Drawing.Size(173, 13);
            this.lbltrasnsSelected.TabIndex = 14;
            this.lbltrasnsSelected.Text = "List of Selected Transactions";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 73);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 25);
            this.button1.TabIndex = 15;
            this.button1.Text = "Clear All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbltrananslist
            // 
            this.lbltrananslist.AutoSize = true;
            this.lbltrananslist.BackColor = System.Drawing.Color.PapayaWhip;
            this.tableLayoutPanel1.SetColumnSpan(this.lbltrananslist, 2);
            this.lbltrananslist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrananslist.Location = new System.Drawing.Point(8, 110);
            this.lbltrananslist.Margin = new System.Windows.Forms.Padding(8, 0, 3, 0);
            this.lbltrananslist.Name = "lbltrananslist";
            this.lbltrananslist.Size = new System.Drawing.Size(119, 13);
            this.lbltrananslist.TabIndex = 16;
            this.lbltrananslist.Text = "List of Transactions";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 455);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.Text = "Miner Fee Calculation";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedTrans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBytes;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblBlockRew;
        private System.Windows.Forms.Label lblTotalRew;
        private System.Windows.Forms.Label txtBlockReward;
        private System.Windows.Forms.Label txtTotalReward;
        private System.Windows.Forms.DataGridView dgvSelectedTrans;
        private System.Windows.Forms.Label lblBlockSiz;
        private System.Windows.Forms.Label txtBlockSize;
        private System.Windows.Forms.Label lbltrasnsSelected;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbltrananslist;
    }
}

