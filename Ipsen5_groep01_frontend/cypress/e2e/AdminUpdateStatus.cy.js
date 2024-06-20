describe('Contract Details Navigation Test', () => {
    it('should_navigate_to_contract_details_and_approve_document', () => {
      login("admin@admin.com", "Admin@123", "http://localhost:5246/signIn");
      cy.get('[data-testid="contract-item"]').first().within(() => {
        cy.get('[data-testid="view-contract-button"]').click();
      });

      cy.get('.button.ok-button').should('be.visible').click();

    });

    it('should_navigate_to_contract_details_and_disapprove_document', () => {
      login("admin@admin.com", "Admin@123", "http://localhost:5246/signIn");
      cy.get('[data-testid="contract-item"]').first().within(() => {
        cy.get('[data-testid="view-contract-button"]').click();
      });

      cy.get('.button.no-button').should('be.visible').click();

    });
  });

  function login(email, password, url) {
    cy.visit(url);
  
    cy.get('.signInButton').click();
    cy.get('#email').type(email);
    cy.get('#email').type(email).clear();
    cy.get('#email').type(email);
    cy.get('#input-password').type(password);
    cy.get('.login-button').click();
    cy.url().should('eq', url);
  }