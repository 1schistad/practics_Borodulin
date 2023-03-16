class SQLCommand
{

    public string CommandText
    {
        get
        {
            return CommandText;
        }
        private set
        {
            CommandText = TextUpper(value);
        }
    }

    private string TextUpper(string CommandText)
    {
        string[] operators = { "create", "drop", "select", "avg", "sum", "min", "insert", "update", "like", "order by", "asc", "desc", "group by", "delete", "table", "alter", "from", "where", "and", "or", "not", "in", "between", "having", "not null", "default", "unique", "primary key", "foreign key", "join", "on","values", "set","is null", "as", "database", "max", "count", "union" };
        for (int i = 0; i < operators.Length; i++)
        {
            CommandText = CommandText.Replace(operators[i], operators[i].ToUpper());
        }
        return CommandText;
    }
    public SQLCommand(string commandText)
    {
        CommandText = commandText;
    }


}