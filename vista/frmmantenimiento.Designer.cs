
namespace GAES_SIREGU.vista
{
    partial class frmmantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmantenimiento));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.addtipo = new System.Windows.Forms.PictureBox();
            this.elipseprin = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnguardarman = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel47 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuDatePicker3 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuDatePicker1 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.bunifuDropdown2 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.cbotipoman = new Bunifu.UI.WinForms.BunifuDropdown();
            ((System.ComponentModel.ISupportInitialize)(this.addtipo)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addtipo
            // 
            this.addtipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addtipo.Image = ((System.Drawing.Image)(resources.GetObject("addtipo.Image")));
            this.addtipo.Location = new System.Drawing.Point(249, 285);
            this.addtipo.Name = "addtipo";
            this.addtipo.Size = new System.Drawing.Size(37, 35);
            this.addtipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addtipo.TabIndex = 112;
            this.addtipo.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.addtipo, "Agregar o editar tipos de mantenimientos ");
            this.bunifuToolTip1.SetToolTipIcon(this.addtipo, null);
            this.bunifuToolTip1.SetToolTipTitle(this.addtipo, "");
            this.addtipo.Click += new System.EventHandler(this.addtipo_Click);
            // 
            // elipseprin
            // 
            this.elipseprin.ElipseRadius = 20;
            this.elipseprin.TargetControl = this;
            // 
            // btnguardarman
            // 
            this.btnguardarman.AllowAnimations = true;
            this.btnguardarman.AllowMouseEffects = true;
            this.btnguardarman.AllowToggling = false;
            this.btnguardarman.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnguardarman.AnimationSpeed = 200;
            this.btnguardarman.AutoGenerateColors = false;
            this.btnguardarman.AutoRoundBorders = true;
            this.btnguardarman.AutoSizeLeftIcon = true;
            this.btnguardarman.AutoSizeRightIcon = true;
            this.btnguardarman.BackColor = System.Drawing.Color.Transparent;
            this.btnguardarman.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(185)))), ((int)(((byte)(20)))));
            this.btnguardarman.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnguardarman.BackgroundImage")));
            this.btnguardarman.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnguardarman.ButtonText = "GUARDAR";
            this.btnguardarman.ButtonTextMarginLeft = 0;
            this.btnguardarman.ColorContrastOnClick = 45;
            this.btnguardarman.ColorContrastOnHover = 45;
            this.btnguardarman.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnguardarman.CustomizableEdges = borderEdges2;
            this.btnguardarman.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnguardarman.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnguardarman.DisabledFillColor = System.Drawing.Color.Transparent;
            this.btnguardarman.DisabledForecolor = System.Drawing.Color.Black;
            this.btnguardarman.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnguardarman.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarman.ForeColor = System.Drawing.Color.Black;
            this.btnguardarman.IconLeft = null;
            this.btnguardarman.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardarman.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnguardarman.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnguardarman.IconMarginLeft = 11;
            this.btnguardarman.IconPadding = 10;
            this.btnguardarman.IconRight = null;
            this.btnguardarman.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnguardarman.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnguardarman.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnguardarman.IconSize = 25;
            this.btnguardarman.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(185)))), ((int)(((byte)(20)))));
            this.btnguardarman.IdleBorderRadius = 37;
            this.btnguardarman.IdleBorderThickness = 1;
            this.btnguardarman.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(185)))), ((int)(((byte)(20)))));
            this.btnguardarman.IdleIconLeftImage = null;
            this.btnguardarman.IdleIconRightImage = null;
            this.btnguardarman.IndicateFocus = true;
            this.btnguardarman.Location = new System.Drawing.Point(462, 320);
            this.btnguardarman.Name = "btnguardarman";
            this.btnguardarman.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnguardarman.OnDisabledState.BorderRadius = 15;
            this.btnguardarman.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnguardarman.OnDisabledState.BorderThickness = 1;
            this.btnguardarman.OnDisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnguardarman.OnDisabledState.ForeColor = System.Drawing.Color.Black;
            this.btnguardarman.OnDisabledState.IconLeftImage = null;
            this.btnguardarman.OnDisabledState.IconRightImage = null;
            this.btnguardarman.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnguardarman.onHoverState.BorderRadius = 15;
            this.btnguardarman.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnguardarman.onHoverState.BorderThickness = 1;
            this.btnguardarman.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnguardarman.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btnguardarman.onHoverState.IconLeftImage = null;
            this.btnguardarman.onHoverState.IconRightImage = null;
            this.btnguardarman.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(185)))), ((int)(((byte)(20)))));
            this.btnguardarman.OnIdleState.BorderRadius = 15;
            this.btnguardarman.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnguardarman.OnIdleState.BorderThickness = 1;
            this.btnguardarman.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(185)))), ((int)(((byte)(20)))));
            this.btnguardarman.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnguardarman.OnIdleState.IconLeftImage = null;
            this.btnguardarman.OnIdleState.IconRightImage = null;
            this.btnguardarman.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnguardarman.OnPressedState.BorderRadius = 15;
            this.btnguardarman.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnguardarman.OnPressedState.BorderThickness = 1;
            this.btnguardarman.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.btnguardarman.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btnguardarman.OnPressedState.IconLeftImage = null;
            this.btnguardarman.OnPressedState.IconRightImage = null;
            this.btnguardarman.Size = new System.Drawing.Size(150, 39);
            this.btnguardarman.TabIndex = 113;
            this.btnguardarman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnguardarman.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnguardarman.TextMarginLeft = 0;
            this.btnguardarman.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip1.SetToolTip(this.btnguardarman, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnguardarman, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnguardarman, "");
            this.btnguardarman.UseDefaultRadiusAndThickness = true;
            this.btnguardarman.Click += new System.EventHandler(this.btnguardarman_Click);
            // 
            // bunifuLabel47
            // 
            this.bunifuLabel47.AllowParentOverrides = false;
            this.bunifuLabel47.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuLabel47.AutoEllipsis = false;
            this.bunifuLabel47.CursorType = null;
            this.bunifuLabel47.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bunifuLabel47.Location = new System.Drawing.Point(302, 184);
            this.bunifuLabel47.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuLabel47.Name = "bunifuLabel47";
            this.bunifuLabel47.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel47.Size = new System.Drawing.Size(106, 17);
            this.bunifuLabel47.TabIndex = 110;
            this.bunifuLabel47.Text = "Fecha de salida:";
            this.bunifuLabel47.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel47.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.bunifuLabel47, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuLabel47, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuLabel47, "");
            // 
            // bunifuDatePicker3
            // 
            this.bunifuDatePicker3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDatePicker3.BorderColor = System.Drawing.Color.Silver;
            this.bunifuDatePicker3.BorderRadius = 8;
            this.bunifuDatePicker3.Color = System.Drawing.Color.Silver;
            this.bunifuDatePicker3.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.bunifuDatePicker3.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.bunifuDatePicker3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker3.DisplayWeekNumbers = false;
            this.bunifuDatePicker3.DPHeight = 0;
            this.bunifuDatePicker3.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.bunifuDatePicker3.FillDatePicker = false;
            this.bunifuDatePicker3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bunifuDatePicker3.ForeColor = System.Drawing.Color.Black;
            this.bunifuDatePicker3.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuDatePicker3.Icon")));
            this.bunifuDatePicker3.IconColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker3.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.bunifuDatePicker3.LeftTextMargin = 5;
            this.bunifuDatePicker3.Location = new System.Drawing.Point(302, 209);
            this.bunifuDatePicker3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuDatePicker3.MinimumSize = new System.Drawing.Size(4, 32);
            this.bunifuDatePicker3.Name = "bunifuDatePicker3";
            this.bunifuDatePicker3.Size = new System.Drawing.Size(310, 32);
            this.bunifuDatePicker3.TabIndex = 111;
            this.bunifuToolTip1.SetToolTip(this.bunifuDatePicker3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuDatePicker3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuDatePicker3, "");
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bunifuLabel5.Location = new System.Drawing.Point(22, 263);
            this.bunifuLabel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(157, 17);
            this.bunifuLabel5.TabIndex = 108;
            this.bunifuLabel5.Text = "Tipo de Mantenimiento :";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.bunifuLabel5, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuLabel5, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuLabel5, "");
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.AcceptsReturn = false;
            this.bunifuTextBox1.AcceptsTab = false;
            this.bunifuTextBox1.AnimationSpeed = 200;
            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox1.AutoSizeHeight = true;
            this.bunifuTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.Gray;
            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.Gray;
            this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.Silver;
            this.bunifuTextBox1.BorderRadius = 8;
            this.bunifuTextBox1.BorderThickness = 1;
            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuTextBox1.DefaultText = "";
            this.bunifuTextBox1.FillColor = System.Drawing.Color.White;
            this.bunifuTextBox1.HideSelection = true;
            this.bunifuTextBox1.IconLeft = null;
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.IconPadding = 10;
            this.bunifuTextBox1.IconRight = null;
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.Lines = new string[0];
            this.bunifuTextBox1.Location = new System.Drawing.Point(22, 127);
            this.bunifuTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuTextBox1.MaxLength = 32767;
            this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.bunifuTextBox1.Modified = false;
            this.bunifuTextBox1.Multiline = true;
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Gray;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bunifuTextBox1.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.Gray;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnIdleState = stateProperties8;
            this.bunifuTextBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bunifuTextBox1.PlaceholderText = "";
            this.bunifuTextBox1.ReadOnly = false;
            this.bunifuTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.SelectionLength = 0;
            this.bunifuTextBox1.SelectionStart = 0;
            this.bunifuTextBox1.ShortcutsEnabled = true;
            this.bunifuTextBox1.Size = new System.Drawing.Size(237, 114);
            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox1.TabIndex = 107;
            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox1.TextMarginBottom = 0;
            this.bunifuTextBox1.TextMarginLeft = 3;
            this.bunifuTextBox1.TextMarginTop = 0;
            this.bunifuTextBox1.TextPlaceholder = "";
            this.bunifuToolTip1.SetToolTip(this.bunifuTextBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuTextBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuTextBox1, "");
            this.bunifuTextBox1.UseSystemPasswordChar = false;
            this.bunifuTextBox1.WordWrap = true;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bunifuLabel3.Location = new System.Drawing.Point(302, 82);
            this.bunifuLabel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(120, 17);
            this.bunifuLabel3.TabIndex = 104;
            this.bunifuLabel3.Text = "Fecha de entrada:";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.bunifuLabel3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuLabel3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuLabel3, "");
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bunifuLabel4.Location = new System.Drawing.Point(22, 102);
            this.bunifuLabel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(86, 17);
            this.bunifuLabel4.TabIndex = 106;
            this.bunifuLabel4.Text = "Observación:";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.bunifuLabel4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuLabel4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuLabel4, "");
            // 
            // bunifuDatePicker1
            // 
            this.bunifuDatePicker1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDatePicker1.BorderColor = System.Drawing.Color.Silver;
            this.bunifuDatePicker1.BorderRadius = 8;
            this.bunifuDatePicker1.Color = System.Drawing.Color.Silver;
            this.bunifuDatePicker1.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.bunifuDatePicker1.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.bunifuDatePicker1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker1.DisplayWeekNumbers = false;
            this.bunifuDatePicker1.DPHeight = 0;
            this.bunifuDatePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.bunifuDatePicker1.FillDatePicker = false;
            this.bunifuDatePicker1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bunifuDatePicker1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDatePicker1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuDatePicker1.Icon")));
            this.bunifuDatePicker1.IconColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker1.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.bunifuDatePicker1.LeftTextMargin = 5;
            this.bunifuDatePicker1.Location = new System.Drawing.Point(302, 107);
            this.bunifuDatePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuDatePicker1.MinimumSize = new System.Drawing.Size(4, 32);
            this.bunifuDatePicker1.Name = "bunifuDatePicker1";
            this.bunifuDatePicker1.Size = new System.Drawing.Size(310, 32);
            this.bunifuDatePicker1.TabIndex = 105;
            this.bunifuToolTip1.SetToolTip(this.bunifuDatePicker1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuDatePicker1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuDatePicker1, "");
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bunifuLabel2.Location = new System.Drawing.Point(22, 21);
            this.bunifuLabel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(64, 17);
            this.bunifuLabel2.TabIndex = 102;
            this.bunifuLabel2.Text = "Vehiculo :";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.bunifuLabel2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuLabel2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuLabel2, "");
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.label2);
            this.bunifuPanel1.Location = new System.Drawing.Point(388, 21);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(254, 42);
            this.bunifuPanel1.TabIndex = 101;
            this.bunifuToolTip1.SetToolTip(this.bunifuPanel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuPanel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuPanel1, "");
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 32);
            this.label2.TabIndex = 117;
            this.label2.Text = "MANTENIMIENTO";
            this.bunifuToolTip1.SetToolTip(this.label2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label2, "");
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 376);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(590, 134);
            this.dataGridView1.TabIndex = 116;
            this.bunifuToolTip1.SetToolTip(this.dataGridView1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.dataGridView1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.dataGridView1, "");
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.Active = true;
            this.bunifuToolTip1.AlignTextWithTitle = false;
            this.bunifuToolTip1.AllowAutoClose = false;
            this.bunifuToolTip1.AllowFading = true;
            this.bunifuToolTip1.AutoCloseDuration = 5000;
            this.bunifuToolTip1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip1.ClickToShowDisplayControl = false;
            this.bunifuToolTip1.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip1.DisplayControl = null;
            this.bunifuToolTip1.EntryAnimationSpeed = 350;
            this.bunifuToolTip1.ExitAnimationSpeed = 200;
            this.bunifuToolTip1.GenerateAutoCloseDuration = false;
            this.bunifuToolTip1.IconMargin = 6;
            this.bunifuToolTip1.InitialDelay = 0;
            this.bunifuToolTip1.Name = "bunifuToolTip1";
            this.bunifuToolTip1.Opacity = 1D;
            this.bunifuToolTip1.OverrideToolTipTitles = false;
            this.bunifuToolTip1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip1.ReshowDelay = 100;
            this.bunifuToolTip1.ShowAlways = true;
            this.bunifuToolTip1.ShowBorders = false;
            this.bunifuToolTip1.ShowIcons = true;
            this.bunifuToolTip1.ShowShadows = true;
            this.bunifuToolTip1.Tag = null;
            this.bunifuToolTip1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip1.TextMargin = 2;
            this.bunifuToolTip1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.TitleForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip1.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip1.ToolTipTitle = null;
            // 
            // bunifuDropdown2
            // 
            this.bunifuDropdown2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown2.BackgroundColor = System.Drawing.Color.White;
            this.bunifuDropdown2.BorderColor = System.Drawing.Color.Silver;
            this.bunifuDropdown2.BorderRadius = 8;
            this.bunifuDropdown2.Color = System.Drawing.Color.Silver;
            this.bunifuDropdown2.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifuDropdown2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuDropdown2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuDropdown2.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuDropdown2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bunifuDropdown2.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.bunifuDropdown2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bunifuDropdown2.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.bunifuDropdown2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifuDropdown2.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown2.FillDropDown = true;
            this.bunifuDropdown2.FillIndicator = false;
            this.bunifuDropdown2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuDropdown2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDropdown2.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown2.FormattingEnabled = true;
            this.bunifuDropdown2.Icon = null;
            this.bunifuDropdown2.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown2.IndicatorColor = System.Drawing.Color.DarkGray;
            this.bunifuDropdown2.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown2.IndicatorThickness = 2;
            this.bunifuDropdown2.IsDropdownOpened = false;
            this.bunifuDropdown2.ItemBackColor = System.Drawing.Color.White;
            this.bunifuDropdown2.ItemBorderColor = System.Drawing.Color.White;
            this.bunifuDropdown2.ItemForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown2.ItemHeight = 26;
            this.bunifuDropdown2.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDropdown2.ItemHighLightForeColor = System.Drawing.Color.White;
            this.bunifuDropdown2.ItemTopMargin = 3;
            this.bunifuDropdown2.Location = new System.Drawing.Point(22, 45);
            this.bunifuDropdown2.Name = "bunifuDropdown2";
            this.bunifuDropdown2.Size = new System.Drawing.Size(237, 32);
            this.bunifuDropdown2.TabIndex = 117;
            this.bunifuDropdown2.Text = null;
            this.bunifuDropdown2.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown2.TextLeftMargin = 5;
            this.bunifuToolTip1.SetToolTip(this.bunifuDropdown2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuDropdown2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuDropdown2, "");
            // 
            // cbotipoman
            // 
            this.cbotipoman.BackColor = System.Drawing.Color.Transparent;
            this.cbotipoman.BackgroundColor = System.Drawing.Color.White;
            this.cbotipoman.BorderColor = System.Drawing.Color.Silver;
            this.cbotipoman.BorderRadius = 8;
            this.cbotipoman.Color = System.Drawing.Color.Silver;
            this.cbotipoman.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbotipoman.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbotipoman.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbotipoman.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbotipoman.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbotipoman.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbotipoman.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbotipoman.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbotipoman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipoman.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbotipoman.FillDropDown = true;
            this.cbotipoman.FillIndicator = false;
            this.cbotipoman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbotipoman.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbotipoman.ForeColor = System.Drawing.Color.Black;
            this.cbotipoman.FormattingEnabled = true;
            this.cbotipoman.Icon = null;
            this.cbotipoman.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbotipoman.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cbotipoman.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbotipoman.IndicatorThickness = 2;
            this.cbotipoman.IsDropdownOpened = false;
            this.cbotipoman.ItemBackColor = System.Drawing.Color.White;
            this.cbotipoman.ItemBorderColor = System.Drawing.Color.White;
            this.cbotipoman.ItemForeColor = System.Drawing.Color.Black;
            this.cbotipoman.ItemHeight = 26;
            this.cbotipoman.ItemHighLightColor = System.Drawing.Color.Silver;
            this.cbotipoman.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbotipoman.ItemTopMargin = 3;
            this.cbotipoman.Location = new System.Drawing.Point(22, 287);
            this.cbotipoman.Name = "cbotipoman";
            this.cbotipoman.Size = new System.Drawing.Size(221, 32);
            this.cbotipoman.TabIndex = 118;
            this.cbotipoman.Text = null;
            this.cbotipoman.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbotipoman.TextLeftMargin = 5;
            this.bunifuToolTip1.SetToolTip(this.cbotipoman, "");
            this.bunifuToolTip1.SetToolTipIcon(this.cbotipoman, null);
            this.bunifuToolTip1.SetToolTipTitle(this.cbotipoman, "");
            this.cbotipoman.SelectedIndexChanged += new System.EventHandler(this.cbotipoman_SelectedIndexChanged_1);
            this.cbotipoman.Click += new System.EventHandler(this.cbotipoman_Click_1);
            // 
            // frmmantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(637, 526);
            this.Controls.Add(this.cbotipoman);
            this.Controls.Add(this.bunifuDropdown2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnguardarman);
            this.Controls.Add(this.addtipo);
            this.Controls.Add(this.bunifuLabel47);
            this.Controls.Add(this.bunifuDatePicker3);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.bunifuTextBox1);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.bunifuDatePicker1);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmmantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmmantenimiento";
            this.Load += new System.EventHandler(this.frmmantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addtipo)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse elipseprin;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnguardarman;
        private System.Windows.Forms.PictureBox addtipo;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel47;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePicker3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePicker1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
        private Bunifu.UI.WinForms.BunifuDropdown cbotipoman;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown2;
    }
}