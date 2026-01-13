using System;

namespace UltraEnterpriseSDLC
{
    class Program
    {
        static void Main(string[] args)
        {
            EnterpriseSDLCEngine engine = new EnterpriseSDLCEngine();

            engine.AddRequirement("Single Sign-On", RiskLevel.High);
            engine.AddRequirement("Fraud Detection", RiskLevel.Critical);

            WorkItem designSSO =engine.CreateWorkItem("Design SSO", SDLCStage.Design);

            WorkItem developSSO = engine.CreateWorkItem("Develop SSO", SDLCStage.Development);

            WorkItem testSSO = engine.CreateWorkItem("Test SSO", SDLCStage.Testing);

            engine.AddDependency(developSSO.Id, designSSO.Id);
            engine.AddDependency(testSSO.Id, developSSO.Id);

            engine.RegisterTestSuite("SSO_REGRESSION_SUITE");
            engine.RegisterTestSuite("SECURITY_SMOKE_SUITE");

            engine.PlanStage(SDLCStage.Design);

            engine.ExecuteNext();
            engine.ExecuteNext();

            engine.DeployRelease("v3.4.1");

            engine.RecordQualityMetric("Code Coverage", 91.7);
            engine.RecordQualityMetric("Security Score", 97.3);

            engine.RollbackRelease();

            engine.PrintAuditLedger();
            engine.PrintReleaseScoreboard();
        }
    }
}
