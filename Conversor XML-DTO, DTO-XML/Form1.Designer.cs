namespace Conversor_XML_DTO__DTO_XML
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
            btn_XMLToDTO = new Button();
            btn_DTOToXML = new Button();
            SuspendLayout();
            // 
            // btn_XMLToDTO
            // 
            btn_XMLToDTO.Location = new Point(153, 130);
            btn_XMLToDTO.Name = "btn_XMLToDTO";
            btn_XMLToDTO.Size = new Size(75, 23);
            btn_XMLToDTO.TabIndex = 0;
            btn_XMLToDTO.Text = "XML_DTO";
            btn_XMLToDTO.UseVisualStyleBackColor = true;
            btn_XMLToDTO.Click += btn_XMLToDTO_Click;
            // 
            // btn_DTOToXML
            // 
            btn_DTOToXML.Location = new Point(304, 130);
            btn_DTOToXML.Name = "btn_DTOToXML";
            btn_DTOToXML.Size = new Size(75, 23);
            btn_DTOToXML.TabIndex = 1;
            btn_DTOToXML.Text = "DTO_XML";
            btn_DTOToXML.UseVisualStyleBackColor = true;
            btn_DTOToXML.Click += btn_DTOToXML_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 276);
            Controls.Add(btn_DTOToXML);
            Controls.Add(btn_XMLToDTO);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_XMLToDTO;
        private Button btn_DTOToXML;
    }
}
