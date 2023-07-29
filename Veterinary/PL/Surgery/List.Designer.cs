namespace Veterinary.PL.Surgery
{
    partial class List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.search = new Bunifu.UI.WinForms.BunifuTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.Return = new System.Windows.Forms.PictureBox();
            this.deletebtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.addbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.updatebtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.DGVsurgery = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVsurgery)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.AcceptsReturn = false;
            this.search.AcceptsTab = false;
            this.search.AnimationSpeed = 200;
            this.search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search.BackgroundImage")));
            this.search.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.search.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.search.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.search.BorderColorIdle = System.Drawing.Color.Silver;
            this.search.BorderRadius = 50;
            this.search.BorderThickness = 1;
            this.search.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search.DefaultFont = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.DefaultText = "";
            this.search.FillColor = System.Drawing.Color.White;
            this.search.HideSelection = true;
            this.search.IconLeft = global::Veterinary.Properties.Resources.search;
            this.search.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.search.IconPadding = 10;
            this.search.IconRight = null;
            this.search.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.search.Lines = new string[0];
            this.search.Location = new System.Drawing.Point(884, 17);
            this.search.Margin = new System.Windows.Forms.Padding(2);
            this.search.MaxLength = 32767;
            this.search.MinimumSize = new System.Drawing.Size(1, 1);
            this.search.Modified = false;
            this.search.Multiline = false;
            this.search.Name = "search";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.search.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.search.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.search.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.search.OnIdleState = stateProperties4;
            this.search.Padding = new System.Windows.Forms.Padding(2);
            this.search.PasswordChar = '\0';
            this.search.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.search.PlaceholderText = "Search";
            this.search.ReadOnly = false;
            this.search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.search.SelectedText = "";
            this.search.SelectionLength = 0;
            this.search.SelectionStart = 0;
            this.search.ShortcutsEnabled = true;
            this.search.Size = new System.Drawing.Size(280, 57);
            this.search.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.search.TabIndex = 0;
            this.search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.search.TextMarginBottom = 0;
            this.search.TextMarginLeft = 3;
            this.search.TextMarginTop = 0;
            this.search.TextPlaceholder = "Search";
            this.search.UseSystemPasswordChar = false;
            this.search.WordWrap = true;
            this.search.TextChange += new System.EventHandler(this.search_TextChange);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.panel1.Controls.Add(this.refresh);
            this.panel1.Controls.Add(this.Return);
            this.panel1.Controls.Add(this.deletebtn);
            this.panel1.Controls.Add(this.addbtn);
            this.panel1.Controls.Add(this.updatebtn);
            this.panel1.Controls.Add(this.search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 90);
            this.panel1.TabIndex = 3;
            // 
            // refresh
            // 
            this.refresh.BackgroundImage = global::Veterinary.Properties.Resources.reload;
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh.Location = new System.Drawing.Point(783, 17);
            this.refresh.Margin = new System.Windows.Forms.Padding(2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(58, 57);
            this.refresh.TabIndex = 2;
            this.refresh.TabStop = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Return
            // 
            this.Return.BackgroundImage = global::Veterinary.Properties.Resources.back;
            this.Return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Return.Location = new System.Drawing.Point(0, 0);
            this.Return.Margin = new System.Windows.Forms.Padding(2);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(44, 44);
            this.Return.TabIndex = 2;
            this.Return.TabStop = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.AllowAnimations = true;
            this.deletebtn.AllowMouseEffects = true;
            this.deletebtn.AllowToggling = false;
            this.deletebtn.AnimationSpeed = 200;
            this.deletebtn.AutoGenerateColors = false;
            this.deletebtn.AutoRoundBorders = false;
            this.deletebtn.AutoSizeLeftIcon = true;
            this.deletebtn.AutoSizeRightIcon = true;
            this.deletebtn.BackColor = System.Drawing.Color.Transparent;
            this.deletebtn.BackColor1 = System.Drawing.Color.Red;
            this.deletebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deletebtn.BackgroundImage")));
            this.deletebtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deletebtn.ButtonText = "Delete";
            this.deletebtn.ButtonTextMarginLeft = 0;
            this.deletebtn.ColorContrastOnClick = 45;
            this.deletebtn.ColorContrastOnHover = 45;
            this.deletebtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.deletebtn.CustomizableEdges = borderEdges1;
            this.deletebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deletebtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.deletebtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.deletebtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.deletebtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.deletebtn.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletebtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.deletebtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.deletebtn.IconMarginLeft = 11;
            this.deletebtn.IconPadding = 10;
            this.deletebtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deletebtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.deletebtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.deletebtn.IconSize = 25;
            this.deletebtn.IdleBorderColor = System.Drawing.Color.Red;
            this.deletebtn.IdleBorderRadius = 30;
            this.deletebtn.IdleBorderThickness = 1;
            this.deletebtn.IdleFillColor = System.Drawing.Color.Red;
            this.deletebtn.IdleIconLeftImage = null;
            this.deletebtn.IdleIconRightImage = null;
            this.deletebtn.IndicateFocus = false;
            this.deletebtn.Location = new System.Drawing.Point(340, 17);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(2);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.deletebtn.OnDisabledState.BorderRadius = 30;
            this.deletebtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deletebtn.OnDisabledState.BorderThickness = 1;
            this.deletebtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.deletebtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.deletebtn.OnDisabledState.IconLeftImage = null;
            this.deletebtn.OnDisabledState.IconRightImage = null;
            this.deletebtn.onHoverState.BorderColor = System.Drawing.Color.Tomato;
            this.deletebtn.onHoverState.BorderRadius = 30;
            this.deletebtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deletebtn.onHoverState.BorderThickness = 1;
            this.deletebtn.onHoverState.FillColor = System.Drawing.Color.Tomato;
            this.deletebtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.deletebtn.onHoverState.IconLeftImage = null;
            this.deletebtn.onHoverState.IconRightImage = null;
            this.deletebtn.OnIdleState.BorderColor = System.Drawing.Color.Red;
            this.deletebtn.OnIdleState.BorderRadius = 30;
            this.deletebtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deletebtn.OnIdleState.BorderThickness = 1;
            this.deletebtn.OnIdleState.FillColor = System.Drawing.Color.Red;
            this.deletebtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.deletebtn.OnIdleState.IconLeftImage = null;
            this.deletebtn.OnIdleState.IconRightImage = null;
            this.deletebtn.OnPressedState.BorderColor = System.Drawing.Color.DarkRed;
            this.deletebtn.OnPressedState.BorderRadius = 30;
            this.deletebtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deletebtn.OnPressedState.BorderThickness = 1;
            this.deletebtn.OnPressedState.FillColor = System.Drawing.Color.DarkRed;
            this.deletebtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.deletebtn.OnPressedState.IconLeftImage = null;
            this.deletebtn.OnPressedState.IconRightImage = null;
            this.deletebtn.Size = new System.Drawing.Size(89, 57);
            this.deletebtn.TabIndex = 1;
            this.deletebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deletebtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.deletebtn.TextMarginLeft = 0;
            this.deletebtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.deletebtn.UseDefaultRadiusAndThickness = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.AllowAnimations = true;
            this.addbtn.AllowMouseEffects = true;
            this.addbtn.AllowToggling = false;
            this.addbtn.AnimationSpeed = 200;
            this.addbtn.AutoGenerateColors = false;
            this.addbtn.AutoRoundBorders = false;
            this.addbtn.AutoSizeLeftIcon = true;
            this.addbtn.AutoSizeRightIcon = true;
            this.addbtn.BackColor = System.Drawing.Color.Transparent;
            this.addbtn.BackColor1 = System.Drawing.Color.DarkCyan;
            this.addbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addbtn.BackgroundImage")));
            this.addbtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addbtn.ButtonText = "Add";
            this.addbtn.ButtonTextMarginLeft = 0;
            this.addbtn.ColorContrastOnClick = 45;
            this.addbtn.ColorContrastOnHover = 45;
            this.addbtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.addbtn.CustomizableEdges = borderEdges2;
            this.addbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.addbtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.addbtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.addbtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.addbtn.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.White;
            this.addbtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addbtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.addbtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.addbtn.IconMarginLeft = 11;
            this.addbtn.IconPadding = 10;
            this.addbtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addbtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.addbtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.addbtn.IconSize = 25;
            this.addbtn.IdleBorderColor = System.Drawing.Color.DarkCyan;
            this.addbtn.IdleBorderRadius = 30;
            this.addbtn.IdleBorderThickness = 1;
            this.addbtn.IdleFillColor = System.Drawing.Color.DarkCyan;
            this.addbtn.IdleIconLeftImage = null;
            this.addbtn.IdleIconRightImage = null;
            this.addbtn.IndicateFocus = false;
            this.addbtn.Location = new System.Drawing.Point(120, 17);
            this.addbtn.Margin = new System.Windows.Forms.Padding(2);
            this.addbtn.Name = "addbtn";
            this.addbtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.addbtn.OnDisabledState.BorderRadius = 30;
            this.addbtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addbtn.OnDisabledState.BorderThickness = 1;
            this.addbtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.addbtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.addbtn.OnDisabledState.IconLeftImage = null;
            this.addbtn.OnDisabledState.IconRightImage = null;
            this.addbtn.onHoverState.BorderColor = System.Drawing.Color.Cyan;
            this.addbtn.onHoverState.BorderRadius = 30;
            this.addbtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addbtn.onHoverState.BorderThickness = 1;
            this.addbtn.onHoverState.FillColor = System.Drawing.Color.Cyan;
            this.addbtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.addbtn.onHoverState.IconLeftImage = null;
            this.addbtn.onHoverState.IconRightImage = null;
            this.addbtn.OnIdleState.BorderColor = System.Drawing.Color.DarkCyan;
            this.addbtn.OnIdleState.BorderRadius = 30;
            this.addbtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addbtn.OnIdleState.BorderThickness = 1;
            this.addbtn.OnIdleState.FillColor = System.Drawing.Color.DarkCyan;
            this.addbtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.addbtn.OnIdleState.IconLeftImage = null;
            this.addbtn.OnIdleState.IconRightImage = null;
            this.addbtn.OnPressedState.BorderColor = System.Drawing.Color.Teal;
            this.addbtn.OnPressedState.BorderRadius = 30;
            this.addbtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addbtn.OnPressedState.BorderThickness = 1;
            this.addbtn.OnPressedState.FillColor = System.Drawing.Color.Teal;
            this.addbtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.addbtn.OnPressedState.IconLeftImage = null;
            this.addbtn.OnPressedState.IconRightImage = null;
            this.addbtn.Size = new System.Drawing.Size(89, 57);
            this.addbtn.TabIndex = 1;
            this.addbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.addbtn.TextMarginLeft = 0;
            this.addbtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.addbtn.UseDefaultRadiusAndThickness = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.AllowAnimations = true;
            this.updatebtn.AllowMouseEffects = true;
            this.updatebtn.AllowToggling = false;
            this.updatebtn.AnimationSpeed = 200;
            this.updatebtn.AutoGenerateColors = false;
            this.updatebtn.AutoRoundBorders = false;
            this.updatebtn.AutoSizeLeftIcon = true;
            this.updatebtn.AutoSizeRightIcon = true;
            this.updatebtn.BackColor = System.Drawing.Color.Transparent;
            this.updatebtn.BackColor1 = System.Drawing.Color.DarkCyan;
            this.updatebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updatebtn.BackgroundImage")));
            this.updatebtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.updatebtn.ButtonText = "Update";
            this.updatebtn.ButtonTextMarginLeft = 0;
            this.updatebtn.ColorContrastOnClick = 45;
            this.updatebtn.ColorContrastOnHover = 45;
            this.updatebtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.updatebtn.CustomizableEdges = borderEdges3;
            this.updatebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.updatebtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.updatebtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.updatebtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.updatebtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.updatebtn.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.Color.White;
            this.updatebtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updatebtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.updatebtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.updatebtn.IconMarginLeft = 11;
            this.updatebtn.IconPadding = 10;
            this.updatebtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updatebtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.updatebtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.updatebtn.IconSize = 25;
            this.updatebtn.IdleBorderColor = System.Drawing.Color.DarkCyan;
            this.updatebtn.IdleBorderRadius = 30;
            this.updatebtn.IdleBorderThickness = 1;
            this.updatebtn.IdleFillColor = System.Drawing.Color.DarkCyan;
            this.updatebtn.IdleIconLeftImage = null;
            this.updatebtn.IdleIconRightImage = null;
            this.updatebtn.IndicateFocus = false;
            this.updatebtn.Location = new System.Drawing.Point(228, 17);
            this.updatebtn.Margin = new System.Windows.Forms.Padding(2);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.updatebtn.OnDisabledState.BorderRadius = 30;
            this.updatebtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.updatebtn.OnDisabledState.BorderThickness = 1;
            this.updatebtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.updatebtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.updatebtn.OnDisabledState.IconLeftImage = null;
            this.updatebtn.OnDisabledState.IconRightImage = null;
            this.updatebtn.onHoverState.BorderColor = System.Drawing.Color.Cyan;
            this.updatebtn.onHoverState.BorderRadius = 30;
            this.updatebtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.updatebtn.onHoverState.BorderThickness = 1;
            this.updatebtn.onHoverState.FillColor = System.Drawing.Color.Cyan;
            this.updatebtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.updatebtn.onHoverState.IconLeftImage = null;
            this.updatebtn.onHoverState.IconRightImage = null;
            this.updatebtn.OnIdleState.BorderColor = System.Drawing.Color.DarkCyan;
            this.updatebtn.OnIdleState.BorderRadius = 30;
            this.updatebtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.updatebtn.OnIdleState.BorderThickness = 1;
            this.updatebtn.OnIdleState.FillColor = System.Drawing.Color.DarkCyan;
            this.updatebtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.updatebtn.OnIdleState.IconLeftImage = null;
            this.updatebtn.OnIdleState.IconRightImage = null;
            this.updatebtn.OnPressedState.BorderColor = System.Drawing.Color.Teal;
            this.updatebtn.OnPressedState.BorderRadius = 30;
            this.updatebtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.updatebtn.OnPressedState.BorderThickness = 1;
            this.updatebtn.OnPressedState.FillColor = System.Drawing.Color.Teal;
            this.updatebtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.updatebtn.OnPressedState.IconLeftImage = null;
            this.updatebtn.OnPressedState.IconRightImage = null;
            this.updatebtn.Size = new System.Drawing.Size(89, 57);
            this.updatebtn.TabIndex = 1;
            this.updatebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updatebtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.updatebtn.TextMarginLeft = 0;
            this.updatebtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.updatebtn.UseDefaultRadiusAndThickness = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // DGVsurgery
            // 
            this.DGVsurgery.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DGVsurgery.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVsurgery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGVsurgery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVsurgery.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(153)))));
            this.DGVsurgery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVsurgery.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVsurgery.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVsurgery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVsurgery.ColumnHeadersHeight = 40;
            this.DGVsurgery.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.DGVsurgery.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DGVsurgery.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVsurgery.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.DGVsurgery.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DGVsurgery.CurrentTheme.BackColor = System.Drawing.Color.Teal;
            this.DGVsurgery.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.DGVsurgery.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Teal;
            this.DGVsurgery.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DGVsurgery.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVsurgery.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DGVsurgery.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DGVsurgery.CurrentTheme.Name = null;
            this.DGVsurgery.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.DGVsurgery.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DGVsurgery.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVsurgery.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.DGVsurgery.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DGVsurgery.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVsurgery.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVsurgery.EnableHeadersVisualStyles = false;
            this.DGVsurgery.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.DGVsurgery.HeaderBackColor = System.Drawing.Color.Teal;
            this.DGVsurgery.HeaderBgColor = System.Drawing.Color.Empty;
            this.DGVsurgery.HeaderForeColor = System.Drawing.Color.White;
            this.DGVsurgery.Location = new System.Drawing.Point(0, 94);
            this.DGVsurgery.Margin = new System.Windows.Forms.Padding(2);
            this.DGVsurgery.Name = "DGVsurgery";
            this.DGVsurgery.RowHeadersVisible = false;
            this.DGVsurgery.RowHeadersWidth = 82;
            this.DGVsurgery.RowTemplate.Height = 40;
            this.DGVsurgery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVsurgery.Size = new System.Drawing.Size(1213, 546);
            this.DGVsurgery.TabIndex = 4;
            this.DGVsurgery.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Teal;
            // 
            // List
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1213, 643);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGVsurgery);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List";
            this.Load += new System.EventHandler(this.List_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVsurgery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextBox search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox refresh;
        private System.Windows.Forms.PictureBox Return;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton deletebtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton updatebtn;
        private Bunifu.UI.WinForms.BunifuDataGridView DGVsurgery;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton addbtn;
    }
}