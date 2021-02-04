SELECT Products.productName, Category.categoryName
FROM     Category RIGHT OUTER JOIN
                  ProductCategory ON Category.ID_Category = ProductCategory.ID_Category INNER JOIN
                  Products ON ProductCategory.ID_Product = Products.ID_product