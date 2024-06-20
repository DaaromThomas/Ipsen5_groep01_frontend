describe('Update contract note', () => {
    it('should_navigate_to_contract_details_and_update_contract_note', () => {
      login("admin@admin.com", "Admin@123", "http://localhost:5246/signIn");
      cy.get('[data-testid="contract-item"]').first().within(() => {
        cy.get('[data-testid="view-contract-button"]').click();
      });

      cy.get('#contractNote').clear().type('Dit is een testopmerking.');
      cy.get('.save-note-button').click();
      cy.get('#contractNote').should('have.value', 'Dit is een testopmerking.');

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