describe('template spec', () => {
    it('passes', () => {
        // Bezoek direct de inlogpagina
        cy.visit('https://localhost:7021/signIn')

        // Controleer of de URL correct is
        cy.url().should('include', '/signIn')

        // Vul het e-mailadres in
       

        // Controleer opnieuw of het wachtwoordveld beschikbaar is en niet is uitgeschakeld
        cy.get('#input-password', { timeout: 10000 }).should('be.visible').and('not.be.disabled').type('Admin@123')

        // Voeg een expliciete wachttijd toe om eventuele JavaScript-acties af te wachten
        cy.wait(5000)

        cy.get('#email', { timeout: 10000 }).should('be.visible').type('admin@admin.com')

        // Voeg een expliciete wachttijd toe om te zien of het wachtwoordveld beschikbaar wordt
        cy.wait(5000)

        // Gebruik een force-klik op de knop om te proberen het formulier in te dienen ondanks eventuele overlays of JavaScript-acties
        cy.get('#login-submit', { timeout: 10000 }).should('be.visible').click({ force: true })

        // Controleer of we zijn ingelogd (bijv. door te controleren of de URL niet langer /signIn bevat)
        cy.url().should('not.include', '/signIn')

        // Navigeer naar de contractpagina
        cy.visit('https://localhost:7021/contract')
        cy.url().should('include', '/contract')

        // Navigeer naar de Customer pagina
        cy.visit('https://localhost:7021/Customer')
        cy.url().should('include', '/Customer')

        // Navigeer naar een specifieke klantpagina
        cy.visit('https://localhost:7021/customer/c2ae261c-234e-4092-b63c-52a5ff80d912')
        cy.url().should('include', '/customer/c2ae261c-234e-4092-b63c-52a5ff80d912')
    })
})
