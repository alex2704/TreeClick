namespace TreeClick
{
    partial class GenerateTree
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
            this.Ok_btn = new System.Windows.Forms.Button();
            this.InputDeep = new System.Windows.Forms.TextBox();
            this.InputNodes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ok_btn
            // 
            this.Ok_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ok_btn.Location = new System.Drawing.Point(379, 30);
            this.Ok_btn.Name = "Ok_btn";
            this.Ok_btn.Size = new System.Drawing.Size(96, 52);
            this.Ok_btn.TabIndex = 0;
            this.Ok_btn.Text = "OK";
            this.Ok_btn.UseVisualStyleBackColor = true;
            this.Ok_btn.Click += new System.EventHandler(this.Ok_btn_Click);
            // 
            // InputDeep
            // 
            this.InputDeep.Location = new System.Drawing.Point(179, 30);
            this.InputDeep.Name = "InputDeep";
            this.InputDeep.Size = new System.Drawing.Size(173, 22);
            this.InputDeep.TabIndex = 1;
            // 
            // InputNodes
            // 
            this.InputNodes.Location = new System.Drawing.Point(179, 91);
            this.InputNodes.Name = "InputNodes";
            this.InputNodes.Size = new System.Drawing.Size(173, 22);
            this.InputNodes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите глубину дерева";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите кол-во дочерних узлов у каждого нода";
            // 
            // GenerateTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 138);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputNodes);
            this.Controls.Add(this.InputDeep);
            this.Controls.Add(this.Ok_btn);
            this.Name = "GenerateTree";
            this.Text = "GenerateTree";
            this.Load += new System.EventHandler(this.GenerateTree_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok_btn;
        private System.Windows.Forms.TextBox InputDeep;
        private System.Windows.Forms.TextBox InputNodes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}