# Temat projektu: Aplikacja do zarządzania sklepami
## LINK: [Click](https://github.com/DawidMalarzWSEI/ShopAppLab)
## Wizualnie
### Okno Logowania
- Pola do wprowadzania danych - przycisk "ZALOGUJ"
- Dane logowania w bazie danych.
- Komunikat o niepoprawnym haśle lub nazwie użytkownika

### Okno sidebar - Funkcje aplikacji
- Zakładka z danymi pracowników
- Zakładka z zadaniami dla każdego z pracowników
- Lista sklepów
- Lista pracowników

#### Zakładka z danymi pracowników
- Tabela z danymi pracownika 
- Wyszukiwanie pracowników według `nazwy sklepu`, `stanowiska`, `id użytkownka`, `imieniu`, `nazwisku`
- Przyciski do `dodawania`, `usuwania`, `edycji` pracownika

#### Zakładka z zadaniami dla każdego z pracowników
- Tabela z taskami
- Wyszukiwanie tasków
- Przycisk do `dodawania`, `usuwania`, `edycji` pracownika

#### Lista sklepów
- Tabela z listą sklepów

#### Lista pracowników
- Tabela z pracownikami + nazwa sklepu

## Technicznie:
### Baza danych
- Tabela Pracownicy
- Tabela Sklepy
- Tabela Zadania
- Tabela Grupy
- Tabela Stanowiska

### ORM + operacje na bazie
- Dodawanie rekordów do bazy
- Usuwanie rekordów
- Pobieranie rekordów jako dane
