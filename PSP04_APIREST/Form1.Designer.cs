
namespace API_REST {
  partial class Form1 {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent() {
            this.bt_T1 = new System.Windows.Forms.Button();
            this.bt_T = new System.Windows.Forms.Button();
            this.lb_temp1 = new System.Windows.Forms.Label();
            this.txt_consulta = new System.Windows.Forms.TextBox();
            this.lb_tiempo1 = new System.Windows.Forms.Label();
            this.lb_temp2 = new System.Windows.Forms.Label();
            this.lb_tiempo2 = new System.Windows.Forms.Label();
            this.txt_ciudad1 = new System.Windows.Forms.TextBox();
            this.txt_ciudad2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_T1
            // 
            this.bt_T1.Location = new System.Drawing.Point(37, 38);
            this.bt_T1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_T1.Name = "bt_T1";
            this.bt_T1.Size = new System.Drawing.Size(189, 57);
            this.bt_T1.TabIndex = 0;
            this.bt_T1.Text = "API REST temperatura1";
            this.bt_T1.UseVisualStyleBackColor = true;
            this.bt_T1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_T
            // 
            this.bt_T.Location = new System.Drawing.Point(37, 119);
            this.bt_T.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_T.Name = "bt_T";
            this.bt_T.Size = new System.Drawing.Size(189, 57);
            this.bt_T.TabIndex = 1;
            this.bt_T.Text = "API REST Temperatura2";
            this.bt_T.UseVisualStyleBackColor = true;
            this.bt_T.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_temp1
            // 
            this.lb_temp1.AutoSize = true;
            this.lb_temp1.Location = new System.Drawing.Point(470, 59);
            this.lb_temp1.Name = "lb_temp1";
            this.lb_temp1.Size = new System.Drawing.Size(20, 15);
            this.lb_temp1.TabIndex = 2;
            this.lb_temp1.Text = "ºC";
            // 
            // txt_consulta
            // 
            this.txt_consulta.Enabled = false;
            this.txt_consulta.Location = new System.Drawing.Point(82, 212);
            this.txt_consulta.Multiline = true;
            this.txt_consulta.Name = "txt_consulta";
            this.txt_consulta.Size = new System.Drawing.Size(754, 272);
            this.txt_consulta.TabIndex = 3;
            // 
            // lb_tiempo1
            // 
            this.lb_tiempo1.AutoSize = true;
            this.lb_tiempo1.Location = new System.Drawing.Point(606, 59);
            this.lb_tiempo1.Name = "lb_tiempo1";
            this.lb_tiempo1.Size = new System.Drawing.Size(134, 15);
            this.lb_tiempo1.TabIndex = 4;
            this.lb_tiempo1.Text = "previsión metereológica";
            // 
            // lb_temp2
            // 
            this.lb_temp2.AutoSize = true;
            this.lb_temp2.Location = new System.Drawing.Point(470, 140);
            this.lb_temp2.Name = "lb_temp2";
            this.lb_temp2.Size = new System.Drawing.Size(20, 15);
            this.lb_temp2.TabIndex = 5;
            this.lb_temp2.Text = "ºC";
            // 
            // lb_tiempo2
            // 
            this.lb_tiempo2.AutoSize = true;
            this.lb_tiempo2.Location = new System.Drawing.Point(606, 140);
            this.lb_tiempo2.Name = "lb_tiempo2";
            this.lb_tiempo2.Size = new System.Drawing.Size(134, 15);
            this.lb_tiempo2.TabIndex = 6;
            this.lb_tiempo2.Text = "previsión metereológica";
            // 
            // txt_ciudad1
            // 
            this.txt_ciudad1.Location = new System.Drawing.Point(250, 56);
            this.txt_ciudad1.Name = "txt_ciudad1";
            this.txt_ciudad1.Size = new System.Drawing.Size(154, 23);
            this.txt_ciudad1.TabIndex = 7;
            this.txt_ciudad1.Text = "inserta nombre ciudad";
            // 
            // txt_ciudad2
            // 
            this.txt_ciudad2.Location = new System.Drawing.Point(250, 132);
            this.txt_ciudad2.Name = "txt_ciudad2";
            this.txt_ciudad2.Size = new System.Drawing.Size(154, 23);
            this.txt_ciudad2.TabIndex = 8;
            this.txt_ciudad2.Text = "inserta nombre ciudad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.txt_ciudad2);
            this.Controls.Add(this.txt_ciudad1);
            this.Controls.Add(this.lb_tiempo2);
            this.Controls.Add(this.lb_temp2);
            this.Controls.Add(this.lb_tiempo1);
            this.Controls.Add(this.txt_consulta);
            this.Controls.Add(this.lb_temp1);
            this.Controls.Add(this.bt_T);
            this.Controls.Add(this.bt_T1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button bt_T1;
    private System.Windows.Forms.Button bt_T;
        private Label lb_temp1;
        private TextBox txt_consulta;
        private Label lb_tiempo1;
        private Label lb_temp2;
        private Label lb_tiempo2;
        private TextBox txt_ciudad1;
        private TextBox txt_ciudad2;
    }
}

