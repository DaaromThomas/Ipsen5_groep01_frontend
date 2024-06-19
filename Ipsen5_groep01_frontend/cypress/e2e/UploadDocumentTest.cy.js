// cypress/integration/example.spec.js

before(() => {
  Cypress.config('baseUrl', 'http://localhost:5246/signIn');
});

describe('Inloggen', () => {
  it('moet succesvol inloggen met admin account', () => {
    // Gebruik het login commando voor admin
    // cy.login('admin@admin.com', 'Admin@123', 'Admin');
    
    // // Controleer of de gebruiker correct wordt doorgestuurd naar de juiste URL
    // cy.location('pathname', { timeout: 10000 }).should('eq', '/contract');
    
    // Voeg hier extra assertions of acties toe die moeten worden uitgevoerd na het inloggen als admin
  });

  it('moet succesvol inloggen met leverancier account', () => {
    // Gebruik het login commando voor leverancier
    cy.login('marcel@gmail.com', 'Marcel123!', 'User');
    cy.location('pathname').should('match', /\/LeverancierDossierScherm\/\d+/);
    
  });
    // Voeg hier extra assertions of acties toe die moeten worden uitgevoerd na het inloggen als leverancier
  });
