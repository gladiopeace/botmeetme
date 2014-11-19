using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MeetMe
{
    public class ThreadHelperClass
    {

        #region Friends
        delegate void LoadRequestFriendCallBack(Form f, ListView list, List<Threading.Friend> lst );
        public static void LoadRequestAddFriend(Form form, ListView list, List<Threading.Friend> lst)
        {
            if (list.InvokeRequired)
            {
                LoadRequestFriendCallBack d = new LoadRequestFriendCallBack(LoadRequestAddFriend);
                form.Invoke(d, new object[] { form, list, lst });
            }
            else
            {
                try
                {
                    int i = 1;
                    list.Items.Clear();
                    foreach (Threading.Friend l in lst)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = i.ToString();
                        item.Tag = l.Link;
                        item.Name = l.Ten;
                        item.SubItems.Add(l.Ten);
                        list.Items.Add(item);
                        i++;
                    }
                }
                catch { }
            }
        }

        delegate void LoadFriendCallBack(Form f, DataGridView list, List<Threading.Friend> lst);
        public static void LoadFriend(Form form, DataGridView list, List<Threading.Friend> lst)
        {
            if (list.InvokeRequired)
            {
                LoadFriendCallBack d = new LoadFriendCallBack(LoadFriend);
                form.Invoke(d, new object[] { form, list, lst });
            }
            else
            {
                try
                {
                    int i = list.Rows.Count;
                    foreach (Threading.Friend l in lst)
                    {
                        try
                        {
                            list.Rows.Add();
                            list.Rows[i - 1].Cells["grdColIndex"].Value = i;
                            list.Rows[i - 1].Cells["grdColAccount"].Value = l.Ten;
                            list.Rows[i - 1].Cells["grdColStatus"].Value = "Success";
                            i++;
                        }
                        catch { i++; }
                    }
                }
                catch { }
            }
        }
        #endregion

        #region Chat
        delegate void LoadListChatCallBack(Form f, ListView list, List<Threading.ListFriendChat> lst);
        public static void LoadListChat(Form form, ListView list, List<Threading.ListFriendChat> lst)
        {
            if (list.InvokeRequired)
            {
                LoadListChatCallBack d = new LoadListChatCallBack(LoadListChat);
                form.Invoke(d, new object[] { form, list, lst });
            }
            else
            {
                try
                {
                    int i = 1;
                    list.Items.Clear();
                    foreach (Threading.ListFriendChat l in lst)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = i.ToString();
                        item.Tag = l.Link;
                        item.Name = l.Name;
                        item.SubItems.Add(l.Name);
                        item.SubItems.Add(l.Content);
                        item.SubItems.Add(l.Day);
                        list.Items.Add(item);
                        i++;
                    }
                }
                catch { }
            }
        }
        #endregion

        #region User

        delegate void LoadUserCallBack(Form f, DataGridView grid,Threading.MyUser user);
        public static void LoadUser(Form form, DataGridView grid, Threading.MyUser user)
        {
            try
            {
                if (grid.InvokeRequired)
                {
                    LoadUserCallBack d = new LoadUserCallBack(LoadUser);
                    form.Invoke(d, new object[] { form, grid, user });
                }
                else
                {
                    int i = grid.Rows.Count - 1;
                    try
                    {
                        grid.Rows.Add();
                        grid.Rows[i].Cells["grdColIndex"].Value = i + 1;
                        grid.Rows[i].Cells["grdColId"].Value = user.Id;
                        grid.Rows[i].Cells["grdColNick"].Value = user.Name;
                        grid.Rows[i].Cells["grdColPass"].Value = user.Pass;
                        grid.Rows[i].Cells["grdColProxy"].Value = user.Proxy;
                        grid.Rows[i].Cells["grdColPort"].Value = user.Port;
                        i++;
                    }
                    catch { i++; }
                }
            }
            catch { }
        }

        #endregion

        #region Form
        delegate void LoadTextCallBack(Form f, DevComponents.DotNetBar.LabelX lbl, string KQ);
        public static void SetText(Form form, DevComponents.DotNetBar.LabelX lbl, string KQ)
        {
            if (lbl.InvokeRequired)
            {
                LoadTextCallBack d = new LoadTextCallBack(SetText);
                form.Invoke(d, new object[] { form, lbl, KQ });
            }
            else
            {
                try
                {
                    lbl.Text = KQ;
                }
                catch { }
            }
        }

        delegate void RemoveCallBack(Form f, DataGridView grid,int index, string KQ);
        public static void RemoveGrid(Form form, DataGridView grid,int index, string KQ)
        {
            if (grid.InvokeRequired)
            {
                RemoveCallBack d = new RemoveCallBack(RemoveGrid);
                form.Invoke(d, new object[] { form, grid,index, KQ });
            }
            else
            {
                try
                {
                    //int start = grid.Rows.Count - 2;
                    for (int i = index; i >= 0; i--)
                    {
                        try
                        {
                            if (grid.Rows[i].Cells["grdColStatus"].Value.ToString() != KQ)
                            {
                                grid.Rows[i].Cells["grdColStatus"].Value = "";
                                grid.Rows.RemoveAt(i);
                            }
                        }
                        catch { }
                    }
                }
                catch { }
            }
        }

        delegate void TimerCallBack(Form f,Timer time, bool value);
        public static void SetTimer(Form form, Timer time, bool value)
        {
            try
            {
                if (form.InvokeRequired)
                {
                    TimerCallBack d = new TimerCallBack(SetTimer);
                    form.Invoke(d, new object[] { form, time, value });
                }
                else
                {
                    try
                    {
                        time.Enabled = value;
                        if (value)
                            time.Start();
                        else
                            time.Stop();

                    }
                    catch { }
                }
            }
            catch { }
        }

        delegate void TimerFullCallBack(Form f, Timer time, bool value, int interval);
        public static void SetTimerFull(Form form, Timer time, bool value, int interval)
        {
            try
            {
                if (form.InvokeRequired)
                {
                    TimerFullCallBack d = new TimerFullCallBack(SetTimerFull);
                    form.Invoke(d, new object[] { form, time, value, interval });
                }
                else
                {
                    try
                    {
                        time.Enabled = value;
                        if (value)
                        {
                            time.Interval = interval;
                            time.Start();
                        }
                        else
                            time.Stop();

                    }
                    catch { }
                }
            }
            catch { }
        }

        delegate void LoadButtonCallBack(Form f, DevComponents.DotNetBar.ButtonX btn, string text);
        public static void SetButton(Form form, DevComponents.DotNetBar.ButtonX btn, string text)
        {
            if (btn.InvokeRequired)
            {
                LoadButtonCallBack d = new LoadButtonCallBack(SetButton);
                form.Invoke(d, new object[] { form, btn, text });
            }
            else
            {
                try
                {
                    btn.Text = text;
                }
                catch { }
            }
        }
        #endregion

    }
}
