# Assignment Solution

##  *GOAL*

1. Banks needs to know how much risk they have in losing money.(By doing some risk calculations).
2. But they already having TDS and RDS which is not sufficient so they want to have new risk system to calculate this risk.
3. This new risk system requires high-level information like trade data of TDS and counterparty data of RDS.
4. For each counterparty data they need to know how much the bank is exposed to risk.
    - All counterparties data and trade data of TDS File Can be found in **XML** format called *Export* which is available on a network share.
5. On this note they need a report of it in MS excel containing risk in figures.
6. This Report should sent to business users before the start of nextday to banks in Singapore.

# Tabulation

| Functional requirements | Object             | Role                | Responsibilities  |
|  :----:        | :------:           | :------:            | :--------:        |
| Import TradeData from **XML** file|**XML**TradeDataImporter|Data Importer|Parse **XML** File and Construct TradeData Object|
|Import ReferenceData from **XML** file|**XML**ReferenceDataImporter|Data Importer|Parse **XML** File and Construct TradeData Object|
|Prepare ReferenceData for Risk Calculation|RiskInputDataManager|Information Holder|Combines Trade data and Counterparty data together|
|Calculate risk|RiskCalculator|Calculator|Calculate Risk|
|Configure Risk with parameters|RiskParameters|Calculate Risk parameters|Calculate risk figure/parameters|
|Export Excel Risk result|RiskResult|Information Holder|Contains Result of calculation|
|Model TradeData|TradeData|Information Holder|Includes informations about TrackID,Date,CurrentTradevalue,CounterpartyID|
|Model RefrenceData|ReferenceData|Information Holder|Includes informations about RefrenceData|


