public class Produto
{
    public int id;
    public string nome;
    public int qtd_estoque;
    public float preco;

    // Método construtor - Com parametros
    public Produto (int p_id,string p_nome,int p_qtd_estoque, float p_preco)
    {
        this.id = p_id;
        this.nome = p_nome;
        this.qtd_estoque = p_qtd_estoque;
        this.preco = p_preco ;

    }
}