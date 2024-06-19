describe('Contract Details Navigation Test', () => {
    it('should_navigate_to_contract_details_and_approve_document', () => {
      // Login als admin of leverancier, afhankelijk van je testgeval
      login("admin@admin.com", "Admin@123", "http://localhost:5246/signIn");

      
  
      // Simuleer navigatie naar contractdetails voor een specifiek contract
      cy.get('[data-testid="contract-item"]').first().within(() => {
        cy.get('[data-testid="view-contract-button"]').click();
      });

      cy.get('.button.ok-button').should('be.visible').click();

    });

    it('should_navigate_to_contract_details_and_disapprove_document', () => {
      // Login als admin of leverancier, afhankelijk van je testgeval
      login("admin@admin.com", "Admin@123", "http://localhost:5246/signIn");

      
  
      // Simuleer navigatie naar contractdetails voor een specifiek contract
      cy.get('[data-testid="contract-item"]').first().within(() => {
        cy.get('[data-testid="view-contract-button"]').click();
      });

      cy.get('.button.no-button').should('be.visible').click();

    });
  });

  function login(email, password, url) {
    cy.visit(url); // Bezoek de inlogpagina
  
    cy.get('.signInButton').click(); // Klik op de inlogknop
  
    cy.get('#email').type(email);
    cy.get('#email').type(email).clear();
    cy.get('#email').type(email); // Voer e-mailadres in
  
    cy.get('#input-password').type(password); // Voer wachtwoord in
  
    cy.get('.login-button').click(); // Klik op de login knop
  
    cy.url().should('eq', url); // Controleer of de URL overeenkomt met de verwachte URL na het inloggen
  }