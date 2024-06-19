// ***********************************************
// This example commands.js shows you how to
// create various custom commands and overwrite
// existing commands.
//
// For more comprehensive examples of custom
// commands please read more here:
// https://on.cypress.io/custom-commands
// ***********************************************
//
//
// -- This is a parent command --
// Cypress.Commands.add('login', (email, password) => { ... })
//
//
// -- This is a child command --
// Cypress.Commands.add('drag', { prevSubject: 'element'}, (subject, options) => { ... })
//
//
// -- This is a dual command --
// Cypress.Commands.add('dismiss', { prevSubject: 'optional'}, (subject, options) => { ... })
//
//
// -- This will overwrite an existing command --
// Cypress.Commands.overwrite('visit', (originalFn, url, options) => { ... })

// cypress/support/commands.js

// cypress/support/commands.js

Cypress.Commands.add('login', (email, password, expectedRole) => {
  cy.wait(2000); 
  cy.visit(''); // Bezoek de inlogpagina
  // Vul het email veld in en zorg ervoor dat het niet is uitgeschakeld
  cy.get('input[id="email"]', { timeout: 30000 }).should('exist').should('not.be.disabled').type(email, {force: true});
  cy.get('input[id="input-password"]', { timeout: 60000 }).should('exist').type(password, {force: true}, {delay: 700});
  cy.debug(); // Of cy.pause()
  cy.get('button[id="login-submit"]', { timeout: 10000 }).should('be.visible').click();


  // Wacht op de navigatie na het inloggen
  if (expectedRole === 'Admin' || expectedRole === 'Employee') {
    cy.location('pathname', { timeout: 10000 }).should('eq', '/contract');
    } else if (expectedRole === 'User') {
      cy.location('pathname', { timeout: 10000 }).should('match', /\/LeverancierDossierScherm\/\d+/);
    }
  });
  
  