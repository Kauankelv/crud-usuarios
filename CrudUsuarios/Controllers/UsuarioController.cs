using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

public class UsuarioController : Controller
{
    string conexao = "server=localhost;database=crud_usuarios;user=root;password=;";

    public IActionResult Index()
    {
        var usuarios = new List<Usuario>();
        using (var conn = new MySqlConnection(conexao))
        {
            conn.Open();
            var cmd = new MySqlCommand("SELECT * FROM usuario", conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                usuarios.Add(new Usuario
                {
                    Id = reader.GetInt32("id"),
                    Nome = reader.GetString("nome"),
                    Email = reader.GetString("email"),
                    Senha = reader.GetString("senha")
                });
            }
        }
        return View(usuarios);
    }

    public IActionResult Criar() => View();

    [HttpPost]
    public IActionResult Criar(Usuario u)
    {
        using (var conn = new MySqlConnection(conexao))
        {
            conn.Open();
            var cmd = new MySqlCommand("INSERT INTO usuario (nome, email, senha) VALUES (@n, @e, @s)", conn);
            cmd.Parameters.AddWithValue("@n", u.Nome);
            cmd.Parameters.AddWithValue("@e", u.Email);
            cmd.Parameters.AddWithValue("@s", u.Senha);
            cmd.ExecuteNonQuery();
        }
        return RedirectToAction("Index");
    }

    public IActionResult Editar(int id)
    {
        Usuario u = null;
        using (var conn = new MySqlConnection(conexao))
        {
            conn.Open();
            var cmd = new MySqlCommand("SELECT * FROM usuario WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                u = new Usuario
                {
                    Id = reader.GetInt32("id"),
                    Nome = reader.GetString("nome"),
                    Email = reader.GetString("email"),
                    Senha = reader.GetString("senha")
                };
            }
        }
        return View(u);
    }

    [HttpPost]
    public IActionResult Editar(Usuario u)
    {
        using (var conn = new MySqlConnection(conexao))
        {
            conn.Open();
            var cmd = new MySqlCommand("UPDATE usuario SET nome=@n, email=@e, senha=@s WHERE id=@id", conn);
            cmd.Parameters.AddWithValue("@n", u.Nome);
            cmd.Parameters.AddWithValue("@e", u.Email);
            cmd.Parameters.AddWithValue("@s", u.Senha);
            cmd.Parameters.AddWithValue("@id", u.Id);
            cmd.ExecuteNonQuery();
        }
        return RedirectToAction("Index");
    }

    public IActionResult Excluir(int id)
    {
        using (var conn = new MySqlConnection(conexao))
        {
            conn.Open();
            var cmd = new MySqlCommand("DELETE FROM usuario WHERE id=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
        return RedirectToAction("Index");
    }
}