namespace FactoryMethodExample.RealWorld
{
    class Resume : Document
    {
        public override void CreatePages()
        {
            this.Pages.Add(new SkillsPage());
            this.Pages.Add(new EducationPage());
            this.Pages.Add(new ExperiencePage());
        }
    }
}
