# API de Gerenciamento de Clientes
Esta API fornece endpoints para listar, adicionar, editar e remover clientes cadastrados. Feito em .NET 6.0

## Endpoints
### 1. Listar Clientes

Endpoint: `api/v1/clients`<br>
Método: _GET_<br>
Descrição: Retorna a lista de todos os clientes cadastrados.

**Resposta de Sucesso:**<br>_json:_
```
[
    {
      "id": 0,
      "nome": "string",
      "documento": "string",
      "endereco": "string",
      "numeroTelefone": "string",
      "empresaId": 0,
      "empresa": {
        "id": 0,
        "nome": "string",
        "porte": 0
      }
    },
    {
      "id": 0,
      "nome": "string",
      "documento": "string",
      "endereco": "string",
      "numeroTelefone": "string",
      "empresaId": 0,
      "empresa": {
        "id": 0,
        "nome": "string",
        "porte": 0
      }
    }
]
```

### 2. Adicionar Cliente
Endpoint: `api/v1/clients`<br>
Método: _POST_<br>
Descrição: Adiciona um novo cliente.

**Corpo da Requisição:**
```
{
  "nome": "string",
  "documento": "string",
  "endereco": "string",
  "numeroTelefone": "string",
  "empresaId": 0
}
```
**Resposta de Sucesso:**
```
{
  "successMessage": "Sucesso ao criar o cliente.",
  "client": {
    "nome": "João",
    "documento": "0123456789",
    "endereco": "RUA A C 01",
    "numeroTelefone": "999999999",
    "empresaId": 1
  }
}
```

## 3. Editar Cliente
Endpoint: `api/v1/clients/<id>`<br>
Método: _PUT_<br>
Descrição: Edita as informações de um cliente existente.

**Corpo da Requisição:**
```
{
  "nome": "string",
  "documento": "string",
  "endereco": "string",
  "numeroTelefone": "string",
  "empresaId": 0
}
```
**Resposta de Sucesso:**
```
{
  "successMessage": "Sucesso ao criar o cliente.",
  "client": {
    "id": 1,
    "nome": "João Silva",
    "documento": "0123456789",
    "endereco": "RUA B C 01",
    "numeroTelefone": "999999999",
    "empresaId": 2
  }
}
```
### 4. Remover Cliente
Endpoint: `api/v1/clients/<id>`<br>
Método: _DELETE_<br>
Descrição: Remove um cliente existente.

**Resposta de Sucesso:**
```
{
  "successMessage": "Sucesso ao excluir o cliente."
}
```
