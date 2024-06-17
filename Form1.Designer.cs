namespace C_SHARP_giaiphuongtrinhbac2
{
    partial class Form1
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
            this.btnkq = new System.Windows.Forms.Button();
            this.lbla = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.lblb = new System.Windows.Forms.Label();
            this.txtb = new System.Windows.Forms.TextBox();
            this.lblc = new System.Windows.Forms.Label();
            this.txtc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grb = new System.Windows.Forms.GroupBox();
            this.lblkq = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnkq
            // 
            this.btnkq.Location = new System.Drawing.Point(313, 247);
            this.btnkq.Name = "btnkq";
            this.btnkq.Size = new System.Drawing.Size(119, 23);
            this.btnkq.TabIndex = 0;
            this.btnkq.Text = "Giải phương trình";
            this.btnkq.UseVisualStyleBackColor = true;
            this.btnkq.Click += new System.EventHandler(this.btnkq_Click);
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(166, 89);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(42, 13);
            this.lbla.TabIndex = 1;
            this.lbla.Text = "Nhập a";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(263, 82);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 2;
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Location = new System.Drawing.Point(166, 140);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(42, 13);
            this.lblb.TabIndex = 1;
            this.lblb.Text = "Nhập b";
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(263, 140);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 20);
            this.txtb.TabIndex = 2;
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Location = new System.Drawing.Point(166, 203);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(42, 13);
            this.lblc.TabIndex = 1;
            this.lblc.Text = "Nhập c";
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(263, 196);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(100, 20);
            this.txtc.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(436, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "ỨNG DỤNG GIẢI PHƯƠNG TRÌNH BẬC 2";
            // 
            // grb
            // 
            this.grb.Controls.Add(this.lblkq);
            this.grb.Location = new System.Drawing.Point(159, 290);
            this.grb.Name = "grb";
            this.grb.Size = new System.Drawing.Size(438, 133);
            this.grb.TabIndex = 3;
            this.grb.TabStop = false;
            this.grb.Text = "KẾT QUẢ";
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(26, 36);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(88, 13);
            this.lblkq.TabIndex = 0;
            this.lblkq.Text = "kết quả ở đây nè";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 450);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(390, 89);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(207, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(390, 140);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(207, 45);
            this.trackBar2.TabIndex = 5;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(390, 196);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(207, 45);
            this.trackBar3.TabIndex = 5;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.grb);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.lblc);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.btnkq);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grb.ResumeLayout(false);
            this.grb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkq;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grb;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblkq;
    }
}

