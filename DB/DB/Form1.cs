using FireSharp.Config;
using FireSharp.Interfaces;
//Fin Youtube : youtube.com/fin_1221


namespace DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FirebaseConfig fff = new FirebaseConfig()
        {
            AuthSecret = "",//DB Password
            BasePath = ""//Site Address
        };
        IFirebaseClient client;
        private void button1_Click(object sender, EventArgs e)
        {
            var result = client.Get("ȸ�� ��� :" + ID.Text);
            upload upd = result.ResultAs<upload>();
            if(upd == null || PW.Text != upd.pw)
            {
                MessageBox.Show("���̵� �Ǵ� ��й�ȣ�� Ʋ��");
            }
            else
            {
                MessageBox.Show("�α��� ����!");
                Form2 form2 = new Form2();
                this.Hide();
                form2.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fff);
            }
            catch
            {
                MessageBox.Show("�ε� ����");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = client.Get("ȸ�� ��� :" + ID.Text);
            upload upd = result.ResultAs<upload>();

            upload upd2 = new upload()
            {
                id = ID.Text, pw = PW.Text
            };
            var send = client.Set("ȸ�� ��� :" + ID.Text, upd2);
            MessageBox.Show("���� �Ϸ�!");
        }
    }
}