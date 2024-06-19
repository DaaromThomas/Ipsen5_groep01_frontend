describe('Sign In Test', () => {
  it('should_login_as_an_admin', () => {
    login("admin@admin.com", "Admin@123", "http://localhost:5246/signIn");
  });
})

function login(email, password, url){
    cy.visit('http://localhost:5246/');

    cy.get('.signInButton').click();

    cy.get('#email').type(email);

    cy.get('#password').type(password);

    cy.get('.login-button').click();

    cy.url().should('eq', url);
}
