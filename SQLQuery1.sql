select p.ProductName as Ürün , o.OrderDate as Tarih ,   SUM(od.Quantity * od.UnitPrice) kazanc  from [Order Details]od
inner join Products p on od.ProductID=p.ProductID
inner join Orders o on od.OrderID=o.OrderID
group by p.ProductName ,o.OrderDate
ORDER BY o.OrderDate DESC;

select o.OrderDate as Tarih ,  SUM(od.Quantity * od.UnitPrice) Kazanc  from [Order Details] od
inner join Orders o on od.OrderID=o.OrderID
GROUP BY OrderDate
ORDER BY OrderDate DESC;

select P.ProductName UrunAdi,SUM((OD.Quantity * OD.UnitPrice) - (OD.Quantity * OD.UnitPrice*OD.Discount)) ToplamSatisMiktari from [Order Details] OD
inner join Products P on P.ProductID=OD.ProductID
group by ProductName
order by ProductName