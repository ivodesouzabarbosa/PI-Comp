using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using System.Linq;

public class DedoDuro : MonoBehaviour
{
#if UNITY_EDITOR
    [MenuItem("Tools/Top 20 Objetos mais pesados do projeto")]
    static void ListarPesados()
    {
        MeshFilter[] todosOsMeshes = Object.FindObjectsOfType<MeshFilter>();

        var listaOrdenada = todosOsMeshes
            .Where(mf => mf.sharedMesh != null)
            .OrderByDescending(mf => mf.sharedMesh.triangles.Length)
            .Take(20)
            .ToArray();

        Debug.Log("TOP 20 OBJETOS VENCEDORES!");

        foreach (var mf in listaOrdenada)
        {
            int tris = mf.sharedMesh.triangles.Length / 3;
            Debug.Log($"🛑 <b>{mf.name}</b> | Tris: {tris:N0}", mf.gameObject);
        }
    }
#endif
}