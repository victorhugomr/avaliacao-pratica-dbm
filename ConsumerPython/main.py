import requests

def get_record_by_id(api_url, record_id):
    response = requests.get(f"{api_url}/{record_id}")
    
    if response.status_code == 200:
        return response.json()
    else:
        print(f"Erro ao buscar o registro: {response.status_code}")
        return None

def categorize_age(age):
    if age < 30:
        return "Jovem"
    elif 30 <= age <= 40:
        return "Adulto"
    else:
        return "Sênior"

def display_record(record):
    if record:
        age_category = categorize_age(record.get("idade", 0))
        print("\nRegistro Consultado:")
        print(f"ID: {record.get('id')}")
        print(f"Nome: {record.get('nome')}")
        print(f"Idade: {record.get('idade')} ({age_category})")
        print(f"Cidade: {record.get('cidade')}")
        print(f"Profissão: {record.get('profissao')}")
    else:
        print("Registro não encontrado.")

if __name__ == "__main__":
    API_URL = "http://localhost:5096/api/records"
    record_id = 1
    record = get_record_by_id(API_URL, record_id)
    display_record(record)
