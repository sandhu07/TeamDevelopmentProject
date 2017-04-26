<?xml version="1.0" encoding="utf-8" ?>
<CodeSnippets  xmlns="http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet">
    <CodeSnippet Format="1.0.0">
        <Header>
            <Title>calPopUp</Title>
            <Shortcut>calPopUp</Shortcut>
            <Description>Calendar PopUp via button</Description>
            <Author>Armando de la Torre</Author>
            <SnippetTypes>
                <SnippetType>Expansion</SnippetType>
            </SnippetTypes>
        </Header>
        <Snippet>
            <Declarations>
        <Literal>
                    <ID>calendar</ID>
                    <ToolTip>calendar control</ToolTip>
                    <Default>cal</Default>
                </Literal>
                <Literal>
                    <ID>button</ID>
                    <ToolTip>Button control</ToolTip>
                    <Default>btnDate</Default>
                </Literal>
        <Literal>
          <ID>text</ID>
          <ToolTip>Text Control</ToolTip>
          <Default>txtDate</Default>
        </Literal>
      </Declarations>
            <Code Language="csharp">
        <![CDATA[
    protected void $button$_Click(object sender, EventArgs e) {
      DateTime date = new DateTime();
      this.$calendar$.Visible = !(this.$calendar$.Visible);
      if (this.$calendar$.Visible) {
        if (DateTime.TryParse($text$.Text,out date)){
          $calendar$.SelectedDate = date;
        }else{
          $calendar$.SelectedDate = DateTime.Today;
        }
        this.$calendar$.Attributes.Add("style","POSITION: absolute");
      }
    }
 
    protected void $calendar$_SelectionChanged(object sender, EventArgs e) {
      $text$.Text = this.$calendar$.SelectedDate.ToString().Substring(0,10);
      this.$calendar$.Visible = false;
    }
$end$]]>
            </Code>
        </Snippet>
    </CodeSnippet>
</CodeSnippets>