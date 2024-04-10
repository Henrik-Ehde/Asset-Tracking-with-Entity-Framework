# Asset Tracking with Entity Framework

A C# Console application used to keep track of the assets (Computers and Phones) owned by a fictional company. The assets are stored in a local database using Entity Framework.

Assets can be added, removed, updated and displayed in a sorted list.

The database stores data about the type of device, model, purchase date, price and which of the companies' offices the asset belongs to. The list will display the price of the asset in USD as well as in the offices' local currency

Each asset is assumed to have a three year lifetime. The asset is displayed in different colors to warn if the asset's lifetime is within six months or three months of it's expiration date.
