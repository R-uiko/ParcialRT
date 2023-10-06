namespace ParcialRT
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
            panelFormulario = new Panel();
            txtFecha = new TextBox();
            btnGuardar = new Button();
            txtLibro = new TextBox();
            labelFecha = new Label();
            labelLibro = new Label();
            txtApellido = new TextBox();
            labelApellido = new Label();
            txtNombre = new TextBox();
            labelNombre = new Label();
            label1 = new Label();
            panelFormulario.SuspendLayout();
            SuspendLayout();
            // 
            // panelFormulario
            // 
            panelFormulario.BackColor = SystemColors.ActiveCaption;
            panelFormulario.Controls.Add(txtFecha);
            panelFormulario.Controls.Add(btnGuardar);
            panelFormulario.Controls.Add(txtLibro);
            panelFormulario.Controls.Add(labelFecha);
            panelFormulario.Controls.Add(labelLibro);
            panelFormulario.Controls.Add(txtApellido);
            panelFormulario.Controls.Add(labelApellido);
            panelFormulario.Controls.Add(txtNombre);
            panelFormulario.Controls.Add(labelNombre);
            panelFormulario.Location = new Point(40, 58);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new Size(720, 329);
            panelFormulario.TabIndex = 0;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(425, 190);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(193, 23);
            txtFecha.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.LimeGreen;
            btnGuardar.Location = new Point(298, 245);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(91, 37);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtLibro
            // 
            txtLibro.Location = new Point(120, 190);
            txtLibro.Name = "txtLibro";
            txtLibro.Size = new Size(172, 23);
            txtLibro.TabIndex = 6;
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelFecha.Location = new Point(425, 159);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(47, 17);
            labelFecha.TabIndex = 5;
            labelFecha.Text = "Fecha:";
            // 
            // labelLibro
            // 
            labelLibro.AutoSize = true;
            labelLibro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelLibro.Location = new Point(120, 159);
            labelLibro.Name = "labelLibro";
            labelLibro.Size = new Size(122, 17);
            labelLibro.TabIndex = 4;
            labelLibro.Text = "Nombre del  libro:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(425, 70);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(193, 23);
            txtApellido.TabIndex = 3;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelApellido.Location = new Point(425, 42);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(64, 17);
            labelApellido.TabIndex = 2;
            labelApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(120, 70);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(172, 23);
            txtNombre.TabIndex = 1;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNombre.Location = new Point(120, 42);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(60, 15);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(338, 19);
            label1.Name = "label1";
            label1.Size = new Size(277, 18);
            label1.TabIndex = 1;
            label1.Text = "Formulario de Prestamo de Libros";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 749);
            Controls.Add(label1);
            Controls.Add(panelFormulario);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelFormulario.ResumeLayout(false);
            panelFormulario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelFormulario;
        private TextBox txtNombre;
        private Label labelNombre;
        private Label labelLibro;
        private TextBox txtApellido;
        private Label labelApellido;
        private TextBox txtLibro;
        private Label labelFecha;
        private Button btnGuardar;
        private Label label1;
        private TextBox txtFecha;
    }
}