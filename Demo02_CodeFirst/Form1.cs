using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Demo01_ModelFirst;

namespace Demo02_CodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void insertOwnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearMenuChecks();
            insertOwnerToolStripMenuItem.Checked = true;

            rtbResult.Clear();

            toolStripStatusLabel.Text = "";
            toolStripStatusLabel.Text = "Через пробел: <last_name> <first_name> <middle_name> <id_home_address> <telephone>";
        }

        private void alterOwnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearMenuChecks();
            alterOwnerToolStripMenuItem.Checked = true;

            rtbResult.Clear();

            toolStripStatusLabel.Text = "";
            toolStripStatusLabel.Text = "Через пробел: <id_owner> <last_name> <first_name> <middle_name> <id_home_address> <telephone>";
        }

        private void deleteOwnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearMenuChecks();
            deleteOwnerToolStripMenuItem.Checked = true;

            rtbResult.Clear();

            toolStripStatusLabel.Text = "";
            toolStripStatusLabel.Text = "<id_owner>";
        }

        private void btnExecute_Click(object sender, System.EventArgs e)
        {
            string input = rtbResult.Text.Trim();
            string[] lines = input.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                foreach (string line in lines)
                {
                    string[] parameters = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (insertOwnerToolStripMenuItem.Checked)
                    {
                        insertOperation(parameters);
                    }
                    else if (alterOwnerToolStripMenuItem.Checked)
                    {
                        alterOperation(parameters);
                    }
                    else if (deleteOwnerToolStripMenuItem.Checked)
                    {
                        deleteOperation(parameters);
                    }
                }

                MessageBox.Show("Операция выполнена успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Логгирование ошибки
                Logger.Log("Demo02_CodeFirst", "ArgumentException: " + ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Ошибка при преобразовании числа: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Логгирование ошибки
                Logger.Log("Demo02_CodeFirst", "FormatException: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка:" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Логгирование ошибки
                Logger.Log("Demo02_CodeFirst", "Exception: " + ex.Message);
            }
        }

        private void insertOperation(string[] parameters)
        {
            // Добавление
            if (parameters.Length < 5)
            {
                throw new ArgumentException("Недостаточно параметров для добавления владельца.");
            }

            // Извлечение параметров из входных данных
            string lastName = parameters[0];
            string firstName = parameters[1];
            string middleName = parameters[2];

            if (!int.TryParse(parameters[3], out int idHomeAddress))
            {
                throw new FormatException("Ошибка при преобразовании id_home_address в число.");
            }

            string telephone = parameters[4];

            // Создание нового объекта владельца
            var newOwner = new Owner
            {
                last_name = lastName,
                first_name = firstName,
                middle_name = middleName,
                id_home_address = idHomeAddress,
                telephone = telephone
            };

            using (var dbContext = new ModelExibitionContainer())
            {
                try
                {
                    dbContext.OwnerSet.Add(newOwner);
                    dbContext.SaveChanges();
                    ShowOwnerlines(dbContext.OwnerSet.ToList(), rtbResult, "\nДанные после добавления:\n");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Произошла ошибка:" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Логгирование операции
                Logger.Log("Demo02_CodeFirst", "Добавлен новый владелец: " + lastName + " " + firstName + " " + middleName);
            }
        }

        private void alterOperation(string[] parameters)
        {
            // Редактирование
            if (parameters.Length < 6)
            {
                throw new ArgumentException("Недостаточно параметров для редактирования владельца.");
            }

            if (!int.TryParse(parameters[0], out int idOwner))
            {
                throw new FormatException("Ошибка при преобразовании id_owner в число.");
            }

            string lastName = parameters[1];
            string firstName = parameters[2];
            string middleName = parameters[3];

            if (!int.TryParse(parameters[4], out int idHomeAddress))
            {
                throw new FormatException("Ошибка при преобразовании id_home_address в число.");
            }

            string telephone = parameters[5];

            using (var dbContext = new ModelExibitionContainer())
            {
                // Получение первого объекта
                var owner = dbContext.OwnerSet.FirstOrDefault(a => a.id_owner == idOwner);
                // Обновление инфы о владельце
                if (owner != null)
                {
                    if (!string.IsNullOrEmpty(lastName))
                        owner.last_name = lastName;

                    if (!string.IsNullOrEmpty(firstName))
                        owner.first_name = firstName;

                    if (!string.IsNullOrEmpty(middleName))
                        owner.middle_name = middleName;

                    if (idHomeAddress != 0)
                        owner.id_home_address = idHomeAddress;

                    if (!string.IsNullOrEmpty(telephone))
                        owner.telephone = telephone;

                    dbContext.SaveChanges();
                }
                // Вывод данных после обновления
                ShowOwnerlines(dbContext.OwnerSet.ToList(), rtbResult, "\nДанные после редактирования:\n");

                // Логгирование операции
                Logger.Log("Demo02_CodeFirst", "Отредактирован владелец с id: " + idOwner);
            }
        }

        private void deleteOperation(string[] parameters)
        {
            // Удаление
            if (parameters.Length < 1)
            {
                throw new ArgumentException("Необходимо указать id_owner для удаления.");
            }

            if (!int.TryParse(parameters[0], out int idOwner))
            {
                throw new FormatException("Ошибка при преобразовании id_owner в число.");
            }

            using (var dbContext = new ModelExibitionContainer())
            {
                // Получение первого объекта
                var ownerToDelete = dbContext.OwnerSet.FirstOrDefault(a => a.id_owner == idOwner);
                if (ownerToDelete != null)
                {
                    // Удаление объекта
                    dbContext.OwnerSet.Remove(ownerToDelete);
                    dbContext.SaveChanges();
                }
                // Вывод данных после удаления
                ShowOwnerlines(dbContext.OwnerSet.ToList(), rtbResult, "\nДанные после удаления владельца:\n");

                // Логгирование операции
                Logger.Log("Demo02_CodeFirst", "Удален владелец с id: " + idOwner);
            }
        }

        private static void ShowOwnerlines(List<Owner> owset, RichTextBox rtbResult, string msg = "")
        {
            rtbResult.AppendText(msg);
            foreach (var owner in owset)
            {
                rtbResult.AppendText($"#{owner.id_owner} -- {owner.last_name} {owner.first_name} {owner.middle_name} --{owner.id_home_address} -- {owner.telephone}\n");
            }
        }

        private void ClearMenuChecks()
        {
            insertOwnerToolStripMenuItem.Checked = false;
            alterOwnerToolStripMenuItem.Checked = false;
            deleteOwnerToolStripMenuItem.Checked = false;
        }

    }
}
