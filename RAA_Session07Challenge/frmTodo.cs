using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RAA_Session07Challenge
{
    public partial class frmTodo : Form
    {
        string TodoFilePath = "";
        BindingList<TodoData> todoDataList = new BindingList<TodoData>();
        TodoData currentEdit;

        public frmTodo(string filePath)
        {
            InitializeComponent();

            lblFilename.Text = Path.GetFileName(filePath);

            string curPath = Path.GetDirectoryName(filePath);
            string curFilename = Path.GetFileNameWithoutExtension(filePath) + "_todo.txt";

            TodoFilePath = curPath + @"\" + curFilename;

            ReadTodoFile();
        }

        private void ReadTodoFile()
        {
            if(File.Exists(TodoFilePath))
            {
                int counter = 0;
                string[] strings = File.ReadAllLines(TodoFilePath);

                foreach(string line in strings)
                {
                    string[] todoData = TodoData.ParseDisplayString(line);

                    TodoData curTodo = new TodoData(counter + 1, todoData[0], todoData[1]);
                    todoDataList.Add(curTodo);
                    counter++;
                }
            }

            ShowData();
        }

        private void ShowData()
        {
            lbxTodo.DataSource = null;
            lbxTodo.DataSource = todoDataList;
            lbxTodo.DisplayMember = "Display";
        }

        private void AddTodoItem(string todoText)
        {
            TodoData curTodo = new TodoData(todoDataList.Count + 1, todoText, "To Do");
            todoDataList.Add(curTodo);

            WriteTodoFile();

        }

        private void RemoveItem(TodoData curTodo)
        {
            todoDataList.Remove(curTodo);
            ReorderTodoItems();
            WriteTodoFile();
        }

        private void ReorderTodoItems()
        {
            for(int i = 0; i < todoDataList.Count; i++)
            {
                todoDataList[i].PositionNumber = i + 1;
                todoDataList[i].UpdateDisplayString();
            }

            WriteTodoFile();
        }

        private void WriteTodoFile()
        {
            using(StreamWriter writer = File.CreateText(TodoFilePath))
            {
                foreach(TodoData curTodo in lbxTodo.Items)
                {
                    curTodo.UpdateDisplayString();
                    writer.WriteLine(curTodo.Display);
                }
            }

            ShowData();
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            if(currentEdit == null)
            {
                AddTodoItem(tbxAddEdit.Text);
            }
            else
            {
                CompleteEditingItem();
            }

            tbxAddEdit.Text = "";
            
        }

        private void CompleteEditingItem()
        {
            foreach(TodoData todo in todoDataList)
            {
                if (todo == currentEdit)
                    todo.Text = tbxAddEdit.Text;
            }

            currentEdit = null;
            lblAddEdit.Text = "Add Item";
            btnAddEdit.Text = "Add Item";

            WriteTodoFile();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lbxTodo.SelectedItems != null)
            {
                TodoData curTodo = lbxTodo.SelectedItem as TodoData;
                RemoveItem(curTodo);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbxTodo.SelectedItems != null)
            {
                TodoData curTodo = lbxTodo.SelectedItem as TodoData;
                StartEditingItem(curTodo);
            }
        }

        private void StartEditingItem(TodoData curTodo)
        {
            currentEdit = curTodo;
            lblAddEdit.Text = "Update Item";
            btnAddEdit.Text = "Update Item";
            tbxAddEdit.Text = curTodo.Text;

            throw new NotImplementedException();
        }

        private void lbxTodo_DoubleClick(object sender, EventArgs e)
        {
            if(lbxTodo.SelectedItems != null)
            {
                TodoData todo = lbxTodo.SelectedItem as TodoData;
                FinishItem(todo);
            }
        }

        private void FinishItem(TodoData todo)
        {
            todo.Status = "Complete";
            WriteTodoFile();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if(lbxTodo.SelectedItems != null)
            {
                TodoData todo = lbxTodo.SelectedItem as TodoData;
                MoveItemUp(todo);
            }
        }

        private void MoveItemUp(TodoData todo)
        {
            for(int i=0; i < todoDataList.Count; i++)
            {
                if(todoDataList[i] == todo)
                {
                    if(i != 0)
                    {
                        todoDataList.RemoveAt(i);
                        todoDataList.Insert(i - 1, todo);
                        ReorderTodoItems();
                    }
                }
            }

            WriteTodoFile();
        }

        private void btnDn_Click(object sender, EventArgs e)
        {
            if (lbxTodo.SelectedItems != null)
            {
                TodoData todo = lbxTodo.SelectedItem as TodoData;
                MoveItemDown(todo);
            }
        }

        private void MoveItemDown(TodoData todo)
        {
            for (int i = 0; i < todoDataList.Count; i++)
            {
                if (todoDataList[i] == todo)
                {
                    if (i <todoDataList.Count-1)
                    {
                        todoDataList.RemoveAt(i);
                        todoDataList.Insert(i + 1, todo);
                        ReorderTodoItems();
                    }
                }
            }

            WriteTodoFile();
        }
    }
}
