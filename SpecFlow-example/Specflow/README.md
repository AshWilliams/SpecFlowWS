
This is sample solution in C# .net. It shows how to generate spec flow result file for given spec flow feature file.

Step 1: Import the given Solution.
Step 2: Open Text Explorer in visual studio by Test->Windows->Test Explorer
Step 3: Execute command in visual studio terminal -> Install-Package NUnitTestAdapter.
	Ignore this step if you have already installed NUnitTestAdapter.
Step 4: Select Run All. 
Step 5: Your result file will be generated at 
{solution_directory} \SpecResults.ApprovalTestSuite\approvals\SpecResults.Json.JsonReporter\
Output.json.
Now, you can Modify Calculator class in CalculatorLibrary in Test, TestSuit.features and Steps.Definitions.cs in SpecResults.ApprovalTestSuite in Test project to generate result file as per your requirement.

This Project is created by taking reference from
https://github.com/timschlechter/SpecResults

