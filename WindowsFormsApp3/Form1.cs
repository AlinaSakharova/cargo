using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "truckingDataSet1.Все_города". При необходимости она может быть перемещена или удалена.
            this.все_городаTableAdapter.Fill(this.truckingDataSet1.Все_города);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "truckingDataSet1.Все_области". При необходимости она может быть перемещена или удалена.
            this.все_областиTableAdapter.Fill(this.truckingDataSet1.Все_области);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "truckingDataSet1.Все_города". При необходимости она может быть перемещена или удалена.
            this.все_городаTableAdapter.Fill(this.truckingDataSet1.Все_города);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "truckingDataSet1.Все_области". При необходимости она может быть перемещена или удалена.
            this.все_областиTableAdapter.Fill(this.truckingDataSet1.Все_области);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "truckingDataSet1.Все_города". При необходимости она может быть перемещена или удалена.
            this.все_городаTableAdapter.Fill(this.truckingDataSet1.Все_города);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "truckingDataSet.ЗаказыНаРейсе". При необходимости она может быть перемещена или удалена.
            this.заказыНаРейсеTableAdapter.Fill(this.truckingDataSet.ЗаказыНаРейсе);
            // вTODO: данная строка кода позволяет загрузить данные в таблицу "truckingDataSet.Рейсы". При необходимости она может быть перемещена или удалена.
            this.рейсыTableAdapter.Fill(this.truckingDataSet.Рейсы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "truckingDataSet.ВсеГрузыВЗаказе". При необходимости она может быть перемещена или удалена.
            this.всеГрузыВЗаказеTableAdapter.Fill(this.truckingDataSet.ВсеГрузыВЗаказе);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "truckingDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.truckingDataSet.Заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "truckingDataSet.Весь_транспорт". При необходимости она может быть перемещена или удалена.
            this.весь_транспортTableAdapter.Fill(this.truckingDataSet.Весь_транспорт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "truckingDataSet.Все_водители". При необходимости она может быть перемещена или удалена.
            this.все_водителиTableAdapter.Fill(this.truckingDataSet.Все_водители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "truckingDataSet.Вид_груза". При необходимости она может быть перемещена или удалена.
            this.вид_грузаTableAdapter.Fill(this.truckingDataSet.Вид_груза);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "truckingDataSet.Грузы". При необходимости она может быть перемещена или удалена.
            this.грузыTableAdapter.Fill(this.truckingDataSet.Грузы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "truckingDataSet.Получатели". При необходимости она может быть перемещена или удалена.
            this.получателиTableAdapter.Fill(this.truckingDataSet.Получатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "truckingDataSet.Все_города". При необходимости она может быть перемещена или удалена.
            this.все_городаTableAdapter.Fill(this.truckingDataSet.Все_города);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "truckingDataSet.Все_области". При необходимости она может быть перемещена или удалена.
            this.все_областиTableAdapter.Fill(this.truckingDataSet.Все_области);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "truckingDataSet.Отправители". При необходимости она может быть перемещена или удалена.
            this.отправителиTableAdapter.Fill(this.truckingDataSet.Отправители);
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.queriesTableAdapter1.ДобавитьОтправителя(this.textBox1.Text, this.textBox2.Text, this.textBox3.Text, Convert.ToInt32(this.comboBox1.SelectedValue), Convert.ToInt32(this.comboBox2.SelectedValue), this.textBox4.Text);
            this.отправителиTableAdapter.Fill(this.truckingDataSet.Отправители);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int p;
            DataRowView j;
            j = (DataRowView)this.отправителиBindingSource.Current;
            p = (int)j["Код_Отправителя"];
            int z;
            int x;
            z = Convert.ToInt32(this.comboBox1.SelectedValue);
            x = Convert.ToInt32(this.comboBox2.SelectedValue);
            this.queriesTableAdapter1.ИзменитьОтправителя(p, this.textBox1.Text, this.textBox2.Text, this.textBox3.Text, z, x,this.textBox4.Text);
            this.отправителиTableAdapter.Fill(this.truckingDataSet.Отправители);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int p;
                DataRowView j;
                j = (DataRowView)this.отправителиBindingSource.Current;
                p = (int)j["Код_Отправителя"];
                this.queriesTableAdapter1.УдалитьОтправителя(p);
                this.отправителиTableAdapter.Fill(this.truckingDataSet.Отправители);
            }
            catch (Exception)
            {
                MessageBox.Show("ВЫ не можете удалить отправителя, так как он включен в заказ");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.queriesTableAdapter1.ДобавитьПолучателя(this.textBox5.Text, this.textBox6.Text, this.textBox7.Text, Convert.ToInt32(this.comboBox3.SelectedValue), Convert.ToInt32(this.comboBox4.SelectedValue), this.textBox8.Text);
            this.получателиTableAdapter.Fill(this.truckingDataSet.Получатели);
        }



        private void button5_Click(object sender, EventArgs e)
        {
            int p;
            DataRowView j;
            j = (DataRowView)this.получателиBindingSource.Current;
            p = (int)j["Код_получателя"];
            int z;
            int x;
            z = Convert.ToInt32(this.comboBox3.SelectedValue);
            x = Convert.ToInt32(this.comboBox4.SelectedValue);
            this.queriesTableAdapter1.ИзменитьПолучателя(p, this.textBox5.Text, this.textBox6.Text, this.textBox7.Text, z, x, this.textBox8.Text);
            this.получателиTableAdapter.Fill(this.truckingDataSet.Получатели);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int p;
                DataRowView j;
                j = (DataRowView)this.получателиBindingSource.Current;
                p = (int)j["Код_получателя"];
                this.queriesTableAdapter1.УдалитьПолучателя(p);
                this.получателиTableAdapter.Fill(this.truckingDataSet.Получатели);
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не можете удалить получателя, так как он включен в заказ");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
                this.queriesTableAdapter1.ДобавитьГруз(Convert.ToInt32(this.comboBox5.SelectedValue), Convert.ToDouble(this.textBox10.Text), Convert.ToDouble(this.textBox9.Text), Convert.ToDouble(this.textBox11.Text));
                this.грузыTableAdapter.Fill(this.truckingDataSet.Грузы);
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int p;
            DataRowView j;
            j = (DataRowView)this.грузыBindingSource.Current;
            p = (int)j["Код_Груза"];
            int z;
            int x;
            z = Convert.ToInt32(this.comboBox5.SelectedValue);
            this.queriesTableAdapter1.ИзменитьГруз(p, z, Convert.ToDouble(this.textBox10.Text), Convert.ToDouble(this.textBox9.Text), Convert.ToDouble(this.textBox11.Text));
            this.грузыTableAdapter.Fill(this.truckingDataSet.Грузы);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                int p;
                DataRowView j;
                j = (DataRowView)this.грузыBindingSource.Current;
                p = (int)j["Код_Груза"];
                this.queriesTableAdapter1.УдалитьГруз(p);
                this.грузыTableAdapter.Fill(this.truckingDataSet.Грузы);
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не можете удалить этот груз, так как он находится в заказе");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.queriesTableAdapter1.ДобавитьВидГруза(this.textBox12.Text);
            this.вид_грузаTableAdapter.Fill(this.truckingDataSet.Вид_груза);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int p;
            DataRowView j;
            j = (DataRowView)this.видгрузаBindingSource.Current;
            p = (int)j["Код_Груза"];
            this.queriesTableAdapter1.ИзменитьВидГруза(p, this.textBox12.Text);
            this.вид_грузаTableAdapter.Fill(this.truckingDataSet.Вид_груза);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                int p;
                DataRowView j;
                j = (DataRowView)this.видгрузаBindingSource.Current;
                p = (int)j["Код_Груза"];
                this.queriesTableAdapter1.УдалитьВидГруза(p);
                this.вид_грузаTableAdapter.Fill(this.truckingDataSet.Вид_груза);
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не можете удалить этот вид груза, так как он присвоен одному из грузов");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.queriesTableAdapter1.ДобавитьВодителя(this.textBox13.Text, Convert.ToInt32(this.textBox14.Text));
            this.все_водителиTableAdapter.Fill(this.truckingDataSet.Все_водители);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int p;
            DataRowView j;
            j = (DataRowView)this.все_водителиBindingSource.Current;
            p = (int)j["Код_водителя"];
            this.queriesTableAdapter1.ИзменитьВодителя(p, this.textBox13.Text,Convert.ToInt32(this.textBox14.Text));
            this.все_водителиTableAdapter.Fill(this.truckingDataSet.Все_водители);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                int p;
                DataRowView j;
                j = (DataRowView)this.все_водителиBindingSource.Current;
                p = (int)j["Код_водителя"];
                this.queriesTableAdapter1.УдалитьВодителя(p);
                this.все_водителиTableAdapter.Fill(this.truckingDataSet.Все_водители);
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не можете удалить водителя, так как он поставлен к заказу");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.queriesTableAdapter1.ДобавитьТранспорт(this.textBox15.Text, Convert.ToDouble(this.textBox16.Text), Convert.ToDouble(this.textBox17.Text));
            this.весь_транспортTableAdapter.Fill(this.truckingDataSet.Весь_транспорт);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int p;
            DataRowView j;
            j = (DataRowView)this.весь_транспортBindingSource.Current;
            p = (int)j["Код_машины"];
            this.queriesTableAdapter1.ИзменитьТранспорт(p, this.textBox15.Text, Convert.ToDouble(this.textBox16.Text), Convert.ToDouble(this.textBox17.Text));
            this.весь_транспортTableAdapter.Fill(this.truckingDataSet.Весь_транспорт);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                int p;
                DataRowView j;
                j = (DataRowView)this.весь_транспортBindingSource.Current;
                p = (int)j["Код_машины"];
                this.queriesTableAdapter1.УдалитьТранспорт(p);
                this.весь_транспортTableAdapter.Fill(this.truckingDataSet.Весь_транспорт);
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не можете удалить транспорт, так как он закреплен за рейсом");
            }
        }

        private void button19_Click(object sender, EventArgs e)

        {         
            this.queriesTableAdapter1.ДобавитьЗаказ(Convert.ToInt32(comboBox6.SelectedValue), Convert.ToInt32(comboBox7.SelectedValue));
            this.заказыTableAdapter.Fill(this.truckingDataSet.Заказы);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int p;
            DataRowView j;
            j = (DataRowView)this.заказыBindingSource.Current;
            p = (int)j["Код_заказа"];
            this.queriesTableAdapter1.ИзменитьЗаказ(p, Convert.ToInt32(comboBox6.SelectedValue), Convert.ToInt32(comboBox7.SelectedValue));
            this.заказыTableAdapter.Fill(this.truckingDataSet.Заказы);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                int p;
                DataRowView j;
                j = (DataRowView)this.заказыBindingSource.Current;
                p = (int)j["Код_заказа"];
                this.queriesTableAdapter1.УдалитьЗаказ(p);
                this.заказыTableAdapter.Fill(this.truckingDataSet.Заказы);
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не можете удалить заказ, так как он погружен на рейс");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.queriesTableAdapter1.ДобавитьРейс(Convert.ToInt32(comboBox8.SelectedValue), Convert.ToInt32(this.textBox18.Text), Convert.ToInt32(this.textBox19.Text), Convert.ToInt32(comboBox9.SelectedValue));
            this.рейсыTableAdapter.Fill(this.truckingDataSet.Рейсы);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int p;
            DataRowView j;
            j = (DataRowView)this.рейсыBindingSource.Current;
            p = (int)j["Код_рейса"];
            this.queriesTableAdapter1.ИзменитьРейс(p, Convert.ToInt32(comboBox8.SelectedValue), Convert.ToInt32(this.textBox18.Text), Convert.ToInt32(this.textBox19.Text), Convert.ToInt32(comboBox9.SelectedValue));
            this.рейсыTableAdapter.Fill(this.truckingDataSet.Рейсы);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                int p;
                DataRowView j;
                j = (DataRowView)this.рейсыBindingSource.Current;
                p = (int)j["Код_рейса"];
                this.queriesTableAdapter1.УдалитьРейс(p);
                this.рейсыTableAdapter.Fill(this.truckingDataSet.Рейсы);
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не можете удалить рейс, так как на нем уже есть заказы");
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.queriesTableAdapter1.ДобавитьГород(this.textBox20.Text);
            this.все_городаTableAdapter.Fill(this.truckingDataSet.Все_города);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int p;
            DataRowView j;
            j = (DataRowView)this.всегородаBindingSource2.Current;
            p = (int)j["Код_города"];
            this.queriesTableAdapter1.ИзменитьГород(p, this.textBox20.Text);
            this.все_городаTableAdapter.Fill(this.truckingDataSet.Все_города);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                int p;
                DataRowView j;
                j = (DataRowView)this.всегородаBindingSource2.Current;
                p = (int)j["Код_города"];
                this.queriesTableAdapter1.УдалитьГород(p);
                this.все_городаTableAdapter.Fill(this.truckingDataSet.Все_города);
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не можете удалить город, так как есть отправитель или получатель, где используется этот город");
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.queriesTableAdapter1.ДобавитьОбласть(this.textBox21.Text);
            this.все_областиTableAdapter.Fill(this.truckingDataSet.Все_области);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            int p;
            DataRowView j;
            j = (DataRowView)this.всеобластиBindingSource2.Current;
            p = (int)j["Код_области"];
            this.queriesTableAdapter1.ИзменитьОбласть(p, this.textBox21.Text);
            this.все_областиTableAdapter.Fill(this.truckingDataSet.Все_области);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                int p;
                DataRowView j;
                j = (DataRowView)this.всеобластиBindingSource2.Current;
                p = (int)j["Код_области"];
                this.queriesTableAdapter1.УдалитьОбласть(p);
                this.все_областиTableAdapter.Fill(this.truckingDataSet.Все_области);
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не можете удалить область, так как есть отправитель или получатель, где используется эта область");
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {
                грузыBindingSource.Filter = this.comboBox11.Text + this.comboBox15.Text + this.textBox22.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка поиска, проверьте запрос");
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            this.queriesTableAdapter1.ДобавитьГрузВЗаказ(Convert.ToInt32(this.comboBox10.SelectedValue), Convert.ToInt32(this.comboBox12.SelectedValue), Convert.ToDouble(this.textBox23.Text), Convert.ToDouble(this.textBox24.Text) );
            this.всеГрузыВЗаказеTableAdapter.Fill(this.truckingDataSet.ВсеГрузыВЗаказе);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            int p;
            DataRowView j;
            j = (DataRowView)this.всеГрузыВЗаказеBindingSource.Current;
            p = (int)j["Код"];
            this.queriesTableAdapter1.ИзменитьГрузыВЗаказе(p, Convert.ToInt32(this.comboBox10.SelectedValue), Convert.ToInt32(this.comboBox12.SelectedValue), Convert.ToDouble(this.textBox23.Text), Convert.ToDouble(this.textBox24.Text));
            this.всеГрузыВЗаказеTableAdapter.Fill(this.truckingDataSet.ВсеГрузыВЗаказе);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            try
            {
                int p;
                DataRowView j;
                j = (DataRowView)this.всеГрузыВЗаказеBindingSource.Current;
                p = (int)j["Код"];
                this.queriesTableAdapter1.УдалитьГрузыИзЗаказа(p);
                this.всеГрузыВЗаказеTableAdapter.Fill(this.truckingDataSet.ВсеГрузыВЗаказе);
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не можете удалить груз из заказа, так как он уже добавлен на рейс");
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            this.queriesTableAdapter1.ДобавитьЗаказНаРейс(Convert.ToInt32(this.comboBox14.SelectedValue),Convert.ToInt32(this.comboBox13.SelectedValue));
            this.заказыНаРейсеTableAdapter.Fill(this.truckingDataSet.ЗаказыНаРейсе);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            int p;
            DataRowView j;
            j = (DataRowView)this.заказыНаРейсеBindingSource.Current;
            p = (int)j["Код"];
            this.queriesTableAdapter1.ИзменитьЗаказНаРейсе(p, Convert.ToInt32(this.comboBox13.SelectedValue),Convert.ToInt32(this.comboBox14.SelectedValue));
            this.заказыНаРейсеTableAdapter.Fill(this.truckingDataSet.ЗаказыНаРейсе);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            try
            {
                int p;
                DataRowView j;
                j = (DataRowView)this.заказыНаРейсеBindingSource.Current;
                p = (int)j["Код"];
                this.queriesTableAdapter1.УдалитьЗаказСРейса(p);
                this.заказыНаРейсеTableAdapter.Fill(this.truckingDataSet.ЗаказыНаРейсе);
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не можете удалить заказ из рейса");
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            все_водителиBindingSource.Filter = this.comboBox16.Text + this.comboBox17.Text + this.textBox25.Text;
        
        }

        private void button39_Click(object sender, EventArgs e)
        {
            try
            {
                весь_транспортBindingSource.Filter = this.comboBox18.Text + this.comboBox19.Text + this.textBox26.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка поиска, проверьте запрос");
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            try
            {
                всеГрузыВЗаказеBindingSource.Filter = this.comboBox20.Text + this.comboBox21.Text + this.textBox27.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка поиска, проверьте запрос");
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            try
            {
                рейсыBindingSource.Filter = this.comboBox22.Text + this.comboBox23.Text + this.textBox28.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка поиска, проверьте запрос");
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
           //try
            {
                отправителиBindingSource.Filter = this.comboBox24.Text + " = '" + this.textBox29.Text+"'";
            }
            //catch (Exception)
            {
                //MessageBox.Show("Ошибка поиска, проверьте запрос");
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedValue != null)
            this.всегородаBindingSource3.Filter = "[Код_области] = " + this.comboBox1.SelectedValue;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox3.SelectedValue != null)
                this.всегородаBindingSource3.Filter = "[Код_области] = " + this.comboBox3.SelectedValue;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
