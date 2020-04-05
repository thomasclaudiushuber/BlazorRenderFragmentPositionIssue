using Microsoft.AspNetCore.Components;
using System;

namespace BlazorRenderFragmentPositionIssue.Components
{
  public class ListItem : ComponentBase, IDisposable
  {
    [CascadingParameter]
    public List ParentList { get; set; }

    [Parameter]
    public string Value { get; set; }

    protected override void OnAfterRender(bool firstRender)
    {
      if (firstRender)
      {
        ParentList.AddItem(Value);
      }
    }

    public void Dispose()
    {
      ParentList.RemoveItem(Value);
    }
  }
}
