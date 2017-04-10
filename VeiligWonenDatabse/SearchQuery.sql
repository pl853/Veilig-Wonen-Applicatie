select StadsGebied.Naam as Gebied, Wijk.Naam as Wijk , [%Criminaliteit].[%Inbraak] as PercentageInbraak
from [%Criminaliteit]
join StadsGebied on [%Criminaliteit].GID = StadsGebied.GID
join Wijk on [%Criminaliteit].WID = Wijk.WID
where Wijk.Naam = 'Stadsdriehoek'