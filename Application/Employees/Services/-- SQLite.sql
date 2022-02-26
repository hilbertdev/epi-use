-- SQLite
SELECT "e"."Name", "e"."Surname", "e"."BirthDate", "e"."EmployeeNumber", "e"."Salary", "r"."RoleDescriptionType" AS "RoleDescription", "e"."ReportingLine"
      FROM "Employees" AS "e"
      INNER JOIN "RoleDescriptions" AS "r" ON "e"."RoleDescriptionId" = "r"."Id"