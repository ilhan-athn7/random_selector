using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_selector
{
    internal class custom_popup_window
    {
    }
}

//Popup form for adding a new item
public class popupForm_Add : Form
{
    private TextBox txt_Item;
    private Button btn_Add;

    public popupForm_Add()
    {
        gen_popupForm_Add();
    }

    private void gen_popupForm_Add()
    {
        txt_Item = new TextBox();
        btn_Add = new Button();

        // Set properties for the TextBox
        txt_Item.Dock = DockStyle.Fill;
        txt_Item.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);

        // Set properties for the OK Button
        btn_Add.Text = "Ekle";
        btn_Add.Dock = DockStyle.Bottom;
        btn_Add.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
        btn_Add.Size = new Size(120, 50);
        btn_Add.Click += btn_Add_Click;


        // Add controls to the form
        Controls.Add(txt_Item);
        Controls.Add(btn_Add);

        // Set form properties
        Text = "Listeye Ekle";
        ClientSize = new Size(300, 95);
        MaximizeBox = false;
        MinimizeBox = false;
        AcceptButton = btn_Add;
        StartPosition = FormStartPosition.CenterParent;
    }

    public string GetEnteredValue()
    {
        return txt_Item.Text;
    }

    public void btn_Add_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
        Close();
    }
}


//Popup form for showing the last choosen item
public class popupForm_Info : Form
{
    private Label lbl_LastChoosen;

    public popupForm_Info(string last_Choosen)
    {
        gen_popupForm_Info(last_Choosen);
    }

    private void gen_popupForm_Info(string last_Choosen)
    {
        lbl_LastChoosen = new Label();

        // Set properties for the Label
        lbl_LastChoosen.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
        lbl_LastChoosen.Text = last_Choosen;
        lbl_LastChoosen.TextAlign = ContentAlignment.MiddleCenter;
        lbl_LastChoosen.AutoSize = false;
        lbl_LastChoosen.Dock = DockStyle.Fill;

        // Add controls to the form
        Controls.Add(lbl_LastChoosen);

        // Set form properties
        Text = "Seçilen";
        ClientSize = new Size(350, 55);
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = FormStartPosition.CenterParent;
    }
}

//Popup form for confirmation of deleting choosen item
public class popupForm_Del : Form
{
    private Label lbl_ChoosenItem;
    private Button btn_Confirm;
    private Button btn_Cancel;

    public popupForm_Del(string choosen_Item)
    {
        gen_popupForm_Del(choosen_Item);
    }

    private void gen_popupForm_Del(string choosen_Item)
    {
        lbl_ChoosenItem = new Label();
        btn_Confirm = new Button();
        btn_Cancel = new Button();

        // Set properties for the Label
        lbl_ChoosenItem.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
        lbl_ChoosenItem.Text = choosen_Item;
        lbl_ChoosenItem.TextAlign = ContentAlignment.MiddleCenter;
        lbl_ChoosenItem.AutoSize = false;
        lbl_ChoosenItem.Dock = DockStyle.Fill;

        // Set properties for the Button
        btn_Confirm.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
        btn_Confirm.Text = "Onayla";
        btn_Confirm.Dock = DockStyle.Fill;
        btn_Confirm.Dock = DockStyle.Bottom;
        btn_Confirm.Size = new Size(120, 50);
        btn_Confirm.Click += btn_Confirm_Click;


        // Set properties for the Button
        btn_Cancel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
        btn_Cancel.Text = "İptal";
        btn_Cancel.Dock = DockStyle.Fill;
        btn_Cancel.Dock = DockStyle.Bottom;
        btn_Cancel.Size = new Size(120, 50);

        // Add controls to the form
        Controls.Add(lbl_ChoosenItem);
        Controls.Add(btn_Confirm);
        Controls.Add(btn_Cancel);

        // Set form properties
        Text = "Eylemi onayla";
        ClientSize = new Size(400, 200);
        MaximizeBox = false;
        MinimizeBox = false;
        AcceptButton = btn_Confirm;
        CancelButton = btn_Cancel;
        StartPosition = FormStartPosition.CenterParent;
    }

    private void btn_Confirm_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
        Close();
    }
}

