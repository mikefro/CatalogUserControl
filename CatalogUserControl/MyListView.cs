using System;
using System.Windows.Forms;

public class MyListView : ListView
{
    private bool mCreating;
    private bool mReadOnly;
    protected override void OnHandleCreated(EventArgs e)
    {
        mCreating = true;
        base.OnHandleCreated(e);
        mCreating = false;
    }
    public bool ReadOnly
    {
        get { return mReadOnly; }
        set { mReadOnly = value; }
    }
    protected override void OnItemCheck(ItemCheckEventArgs e)
    {
        if (!mCreating && mReadOnly) e.NewValue = e.CurrentValue;
        base.OnItemCheck(e);
    }
}

