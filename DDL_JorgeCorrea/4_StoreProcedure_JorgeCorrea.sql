CREATE PROCEDURE `GetTotalEmployeesByDepartment` ()

	SELECT D.Name, COUNT(E.DepartmentId) AS Total
	FROM Department D
	LEFT JOIN Employee E
	ON D.Id = E.DepartmentId
	GROUP BY D.Name
	ORDER BY Total DESC, Name ASC;