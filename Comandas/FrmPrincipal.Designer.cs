namespace Comandas
{
    partial class FrmPrincipal
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
            gpxPrincipal = new GroupBox();
            btnUsuario = new ReaLTaiizor.Controls.MetroButton();
            btnPedidoCozinha = new ReaLTaiizor.Controls.MetroButton();
            btnComanda = new ReaLTaiizor.Controls.MetroButton();
            btnCardapio = new ReaLTaiizor.Controls.MetroButton();
            btnVoltar = new ReaLTaiizor.Controls.CyberButton();
            gpxPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // gpxPrincipal
            // 
            gpxPrincipal.Controls.Add(btnUsuario);
            gpxPrincipal.Controls.Add(btnPedidoCozinha);
            gpxPrincipal.Controls.Add(btnComanda);
            gpxPrincipal.Controls.Add(btnCardapio);
            gpxPrincipal.Location = new Point(12, 55);
            gpxPrincipal.Name = "gpxPrincipal";
            gpxPrincipal.Size = new Size(764, 303);
            gpxPrincipal.TabIndex = 0;
            gpxPrincipal.TabStop = false;
            // 
            // btnUsuario
            // 
            btnUsuario.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnUsuario.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnUsuario.DisabledForeColor = Color.Gray;
            btnUsuario.Font = new Font("Microsoft Sans Serif", 10F);
            btnUsuario.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnUsuario.HoverColor = Color.FromArgb(95, 207, 255);
            btnUsuario.HoverTextColor = Color.White;
            btnUsuario.IsDerivedStyle = true;
            btnUsuario.Location = new Point(546, 51);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnUsuario.NormalColor = Color.FromArgb(65, 177, 225);
            btnUsuario.NormalTextColor = Color.White;
            btnUsuario.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnUsuario.PressColor = Color.FromArgb(35, 147, 195);
            btnUsuario.PressTextColor = Color.White;
            btnUsuario.Size = new Size(143, 128);
            btnUsuario.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnUsuario.StyleManager = null;
            btnUsuario.TabIndex = 3;
            btnUsuario.Text = "Usuários";
            btnUsuario.ThemeAuthor = "Taiizor";
            btnUsuario.ThemeName = "MetroLight";
            btnUsuario.Click += btnUsuarios_Click;
            // 
            // btnPedidoCozinha
            // 
            btnPedidoCozinha.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnPedidoCozinha.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnPedidoCozinha.DisabledForeColor = Color.Gray;
            btnPedidoCozinha.Font = new Font("Microsoft Sans Serif", 10F);
            btnPedidoCozinha.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnPedidoCozinha.HoverColor = Color.FromArgb(95, 207, 255);
            btnPedidoCozinha.HoverTextColor = Color.White;
            btnPedidoCozinha.IsDerivedStyle = true;
            btnPedidoCozinha.Location = new Point(374, 51);
            btnPedidoCozinha.Name = "btnPedidoCozinha";
            btnPedidoCozinha.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnPedidoCozinha.NormalColor = Color.FromArgb(65, 177, 225);
            btnPedidoCozinha.NormalTextColor = Color.White;
            btnPedidoCozinha.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnPedidoCozinha.PressColor = Color.FromArgb(35, 147, 195);
            btnPedidoCozinha.PressTextColor = Color.White;
            btnPedidoCozinha.Size = new Size(143, 128);
            btnPedidoCozinha.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnPedidoCozinha.StyleManager = null;
            btnPedidoCozinha.TabIndex = 2;
            btnPedidoCozinha.Text = "Pedido Cozinha";
            btnPedidoCozinha.ThemeAuthor = "Taiizor";
            btnPedidoCozinha.ThemeName = "MetroLight";
            btnPedidoCozinha.Click += btnPedidoCozinha_Click;
            // 
            // btnComanda
            // 
            btnComanda.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnComanda.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnComanda.DisabledForeColor = Color.Gray;
            btnComanda.Font = new Font("Microsoft Sans Serif", 10F);
            btnComanda.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnComanda.HoverColor = Color.FromArgb(95, 207, 255);
            btnComanda.HoverTextColor = Color.White;
            btnComanda.IsDerivedStyle = true;
            btnComanda.Location = new Point(204, 51);
            btnComanda.Name = "btnComanda";
            btnComanda.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnComanda.NormalColor = Color.FromArgb(65, 177, 225);
            btnComanda.NormalTextColor = Color.White;
            btnComanda.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnComanda.PressColor = Color.FromArgb(35, 147, 195);
            btnComanda.PressTextColor = Color.White;
            btnComanda.Size = new Size(143, 128);
            btnComanda.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnComanda.StyleManager = null;
            btnComanda.TabIndex = 1;
            btnComanda.Text = "Comanda";
            btnComanda.ThemeAuthor = "Taiizor";
            btnComanda.ThemeName = "MetroLight";
            btnComanda.Click += btnComanda_Click_1;
            // 
            // btnCardapio
            // 
            btnCardapio.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnCardapio.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnCardapio.DisabledForeColor = Color.Gray;
            btnCardapio.Font = new Font("Microsoft Sans Serif", 10F);
            btnCardapio.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnCardapio.HoverColor = Color.FromArgb(95, 207, 255);
            btnCardapio.HoverTextColor = Color.White;
            btnCardapio.IsDerivedStyle = true;
            btnCardapio.Location = new Point(34, 51);
            btnCardapio.Name = "btnCardapio";
            btnCardapio.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnCardapio.NormalColor = Color.FromArgb(65, 177, 225);
            btnCardapio.NormalTextColor = Color.White;
            btnCardapio.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnCardapio.PressColor = Color.FromArgb(35, 147, 195);
            btnCardapio.PressTextColor = Color.White;
            btnCardapio.Size = new Size(143, 128);
            btnCardapio.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnCardapio.StyleManager = null;
            btnCardapio.TabIndex = 0;
            btnCardapio.Text = "Cardápio";
            btnCardapio.ThemeAuthor = "Taiizor";
            btnCardapio.ThemeName = "MetroLight";
            btnCardapio.Click += btnCardapio_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Alpha = 20;
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Background = true;
            btnVoltar.Background_WidthPen = 4F;
            btnVoltar.BackgroundPen = true;
            btnVoltar.ColorBackground = Color.FromArgb(37, 52, 68);
            btnVoltar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnVoltar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnVoltar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnVoltar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnVoltar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnVoltar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnVoltar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnVoltar.Effect_1 = true;
            btnVoltar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnVoltar.Effect_1_Transparency = 25;
            btnVoltar.Effect_2 = true;
            btnVoltar.Effect_2_ColorBackground = Color.White;
            btnVoltar.Effect_2_Transparency = 20;
            btnVoltar.Font = new Font("Arial", 11F);
            btnVoltar.ForeColor = Color.FromArgb(245, 245, 245);
            btnVoltar.Lighting = false;
            btnVoltar.LinearGradient_Background = false;
            btnVoltar.LinearGradientPen = false;
            btnVoltar.Location = new Point(12, 363);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.PenWidth = 15;
            btnVoltar.Rounding = true;
            btnVoltar.RoundingInt = 70;
            btnVoltar.Size = new Size(195, 75);
            btnVoltar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnVoltar.TabIndex = 1;
            btnVoltar.Tag = "Cyber";
            btnVoltar.TextButton = "Voltar";
            btnVoltar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnVoltar.Timer_Effect_1 = 5;
            btnVoltar.Timer_RGB = 300;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(gpxPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de comandas";
            Load += FrmPrincipal_Load;
            gpxPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpxPrincipal;
        private ReaLTaiizor.Controls.MetroButton btnUsuario;
        private ReaLTaiizor.Controls.MetroButton btnPedidoCozinha;
        private ReaLTaiizor.Controls.MetroButton btnComanda;
        private ReaLTaiizor.Controls.MetroButton btnCardapio;
        private ReaLTaiizor.Controls.CyberButton btnVoltar;
    }
}