/*CREATE PROCEDURE GetAllProductCategoriesAndSubcategories
AS
BEGIN
    SELECT pc.Name AS CategoryName, ps.Name AS SubcategoryName
    FROM Production.ProductCategory pc
    LEFT JOIN Production.ProductSubcategory ps ON pc.ProductCategoryID = ps.ProductCategoryID;
END;*/

/*CREATE PROCEDURE GetProductSalesByYear
AS
BEGIN
    SELECT YEAR(soh.OrderDate) AS SalesYear, SUM(sod.LineTotal) AS TotalSales
    FROM Sales.SalesOrderHeader soh
    INNER JOIN Sales.SalesOrderDetail sod ON soh.SalesOrderID = sod.SalesOrderID
    GROUP BY YEAR(soh.OrderDate)
    ORDER BY SalesYear;
END;
*/
/*CREATE PROCEDURE GetProductReviews
AS
BEGIN
    SELECT pr.ProductReviewID, p.Name AS ProductName, p.ProductModelID, pm.Name AS ModelName, pr.ReviewDate, pr.Rating, pr.Comments
    FROM Production.ProductReview pr
    INNER JOIN Production.Product p ON pr.ProductID = p.ProductID
    LEFT JOIN Production.ProductModel pm ON p.ProductModelID = pm.ProductModelID
    ORDER BY pr.ReviewDate DESC;
END;
*/


