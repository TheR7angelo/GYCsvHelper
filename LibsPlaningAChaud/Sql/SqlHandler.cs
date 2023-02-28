using LibsPlaningAChaud.CsvReader;
using LibsPlaningAChaud.Sql.Struc;

namespace LibsPlaningAChaud.Sql;

public class SqlHandler
{
    private readonly SqLite _sqLite;

    public SqlHandler(string filePath)
    {
        _sqLite = new SqLite(filePath);
        // Activites = GetAllActivity();
        CleanTable();
    }

    private void CleanTable()
    {
        const string cmd = """
        DELETE FROM t_prod_data;
        UPDATE sqlite_sequence SET seq = 0 WHERE name = 't_prod_data';
        """;
        _sqLite.Execute(cmd);
    }

    public void ImportRows(IEnumerable<ExportInterventionCsv> rows, EActivity activity)
    {
        var cmdClear = $"DELETE FROM t_prod_data WHERE activite = {(int)activity}";
        _sqLite.Execute(cmdClear);

        const string cmdStr = """
            INSERT INTO t_prod_data (activite, type_inter, nd, planif_fT, ui, act_prod, client, adresse, code_postal, ville_site)
            VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})
        """;
        foreach (var row in rows)
        {
            var cmd = string.Format(cmdStr, row.Activity, _sqLite.SqlNull(row.TypeInter), _sqLite.SqlNull(row.Nd),
                _sqLite.SqlNull(row.PlanifFt), _sqLite.SqlNull(row.Ui), _sqLite.SqlNull(row.ActProd),
                _sqLite.SqlNull(row.Client),
                _sqLite.SqlNull(row.Adresse), _sqLite.SqlNull(row.PostalCode), _sqLite.SqlNull(row.VilleSite));
            _sqLite.Execute(cmd);
        }
    }

    public IEnumerable<VProdData> GetRows()
    {
        const string cmd = "SELECT * FROM v_prod_data;";

        var result = new List<VProdData>();
        var reader = _sqLite.ExecuteReader(cmd);
        while (reader.Read())
        {
            result.Add(new VProdData
            {
                Id = int.Parse(reader["id"].ToString()!),
                Activity = reader["activite"].ToString()!,
                Onglet = reader["onglet"].ToString()!,
                TypeInter = reader["type_inter"].ToString(),
                Nd = reader["nd"].ToString(),
                PlanifFt = reader["planif_fT"].ToString(),
                Ui = reader["ui"].ToString(),
                ActProd = reader["act_prod"].ToString(),
                Client = reader["client"].ToString(),
                Adresse = reader["adresse"].ToString(),
                PostalCode = reader["code_postal"].ToString(),
                VilleSite = reader["ville_site"].ToString(),
                Contact = reader["contact"].ToString(),
                EscaladeN1 = reader["escalade_n1"].ToString()
            });
        }

        return result;
    }

    public IEnumerable<Contact> GetAllContact()
    {
        const string cmd = "SELECT * FROM t_contact ORDER BY nom";

        var result = new List<Contact>();
        var reader = _sqLite.ExecuteReader(cmd);
        while (reader.Read())
        {
            result.Add(new Contact
            {
                Id = int.Parse(reader["id"].ToString()!),
                LastName = reader["nom"].ToString()!,
                FirstName = reader["prenom"].ToString()!,
                Number = reader["numbers"].ToString()!
            });
        }

        return result;
    }

    public void UpdateCantact(Contact contact)
    {
        var cmd =
            $"""
            UPDATE t_contact SET nom='{contact.LastName}',
                                 prenom='{contact.FirstName}',
                                 numbers='{contact.Number}'
                             WHERE id={contact.Id};
            """;
        _sqLite.Execute(cmd);
    }

    public long NewContact(Contact contact)
    {
        var cmd =
            $"""
            INSERT INTO t_contact(nom, prenom, numbers) 
                        VALUES ({_sqLite.SqlNull(contact.LastName)}, {_sqLite.SqlNull(contact.FirstName)}, {_sqLite.SqlNull(contact.Number)})
            """;
        return _sqLite.Execute(cmd);
    }

    public void DeleteContact(Contact contact)
    {
        var cmd = $"DELETE FROM t_contact WHERE id={contact.Id}";
        _sqLite.Execute(cmd);
    }

    public IEnumerable<Zone> GetAllZones()
    {
        const string cmd = "SELECT * FROM t_prod_zone ORDER BY activite, dept;";
        var reader = _sqLite.ExecuteReader(cmd);

        var contact = GetAllContact().ToList();
        
        var result = new List<Zone>();
        while (reader.Read())
        {
            var id = int.Parse(reader["id"].ToString()!);
            var activity = (EActivity)int.Parse(reader["activite"].ToString()!);
            var department = int.Parse(reader["dept"].ToString()!);
            var ui = reader["ui"].ToString()!;
            var ct = contact.First(s => s.Id.Equals(int.Parse(reader["contact"].ToString()!)));
            var escaladeN1 = contact.First(s => s.Id.Equals(int.Parse(reader["escalade_n1"].ToString()!)));
            
            result.Add(new Zone
            {
                Id = id,
                Activity = activity,
                Department = department,
                Ui = ui,
                Contact = ct,
                EscaladeN1 = escaladeN1
            });
        }

        return result;
    }

    public void InsertNewDept(EActivity activity, int dept, string ui)
    {
        var cmd = $"""
                INSERT INTO t_prod_zone(activite, dept, ui)
                            VALUES ({(int)activity}, {dept}, {_sqLite.SqlNull(ui)});
                """;
        _sqLite.Execute(cmd);
    }
}