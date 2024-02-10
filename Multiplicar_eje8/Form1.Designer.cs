namespace Multiplicar_eje8
{
    partial class Form1
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
            lst_Tabla = new ListBox();
            label1 = new Label();
            btn_Calcular = new Button();
            btn_Limpiar = new Button();
            btn_Salir = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txt_Numero = new TextBox();
            Ta = new Label();
            SuspendLayout();
            // 
            // lst_Tabla
            // 
            lst_Tabla.FormattingEnabled = true;
            lst_Tabla.ItemHeight = 25;
            lst_Tabla.Location = new Point(55, 167);
            lst_Tabla.Name = "lst_Tabla";
            lst_Tabla.Size = new Size(180, 304);
            lst_Tabla.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 141);
            label1.Name = "label1";
            label1.Size = new Size(63, 30);
            label1.TabIndex = 1;
            label1.Text = "Valor";
            // 
            // btn_Calcular
            // 
            btn_Calcular.Font = new Font("Segoe UI", 11F);
            btn_Calcular.Location = new Point(307, 253);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(112, 34);
            btn_Calcular.TabIndex = 2;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = true;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.Font = new Font("Segoe UI", 11F);
            btn_Limpiar.Location = new Point(307, 318);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(112, 34);
            btn_Limpiar.TabIndex = 3;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = true;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.Font = new Font("Segoe UI", 11F);
            btn_Salir.Location = new Point(307, 385);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(112, 34);
            btn_Salir.TabIndex = 4;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // txt_Numero
            // 
            txt_Numero.Location = new Point(283, 187);
            txt_Numero.Name = "txt_Numero";
            txt_Numero.Size = new Size(150, 31);
            txt_Numero.TabIndex = 5;
            // 
            // Ta
            // 
            Ta.AutoSize = true;
            Ta.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Ta.Location = new Point(150, 43);
            Ta.Name = "Ta";
            Ta.Size = new Size(317, 45);
            Ta.TabIndex = 6;
            Ta.Text = "Tabla de Multiplicar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(554, 513);
            Controls.Add(Ta);
            Controls.Add(txt_Numero);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_Calcular);
            Controls.Add(label1);
            Controls.Add(lst_Tabla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lst_Tabla;
        private Label label1;
        private Button btn_Calcular;
        private Button btn_Limpiar;
        private Button btn_Salir;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txt_Numero;
        private Label Ta;
    }
}
